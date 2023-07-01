clear

#assemble boot.s file
as --32 boot.s -o obj/boot.o

#compile every .c file
echo "Compiling C Files..."
gcc -m32 -c kernel.c -o obj/kernel.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
gcc -m32 -c drivers/keyboard.c -o obj/keyboard.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
gcc -m32 -c include/utils.c -o obj/utils.o -std=gnu99 -ffreestanding -O2 -Wall -Wextra
echo "Finished"

#linking the kernel with kernel.o and boot.o files
echo "Linking..."
ld -m elf_i386 -T linker.ld obj/kernel.o obj/keyboard.o obj/utils.o obj/boot.o -o MWOS.bin -nostdlib
echo "Finished"

#check .bin file is x86 multiboot file or not
# multiboot /boot/.bin
echo "Building..."
grub-file --is-x86-multiboot MWOS.bin

#building the iso file
mkdir -p isodir/boot/grub
cp MWOS.bin isodir/boot/MWOS.bin
cp grub.cfg isodir/boot/grub/grub.cfg
grub-mkrescue -o MWOS.iso isodir
echo "Finished"

#run it in qemu
qemu-system-x86_64 -cdrom MWOS.iso
