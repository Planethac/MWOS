clear

#assemble boot.s file
as --32 boot.s -o boot.o

#compile every .c file
echo "Compiling C Files..."
echo
gcc -m32 -c kernel.c -o kernel.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
gcc -m32 -c char.c -o char.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
gcc -m32 -c utils.c -o utils.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
echo
echo "Finished"
echo

#linking the kernel with kernel.o and boot.o files
echo "Linking..."
echo
ld -m elf_i386 -T linker.ld kernel.o boot.o -o MyOS.bin -nostdlib
echo
echo "Finished"
echo

#check MyOS.bin file is x86 multiboot file or not
# multiboot /boot/MyOS.bin
echo "Building..."
echo
grub-file --is-x86-multiboot MyOS.bin

#building the iso file
mkdir -p isodir/boot/grub
cp MyOS.bin isodir/boot/MyOS.bin
cp grub.cfg isodir/boot/grub/grub.cfg
grub-mkrescue -o MyOS.iso isodir
echo
echo "Finished"
echo

#run it in qemu
qemu-system-x86_64 -cdrom MyOS.iso
