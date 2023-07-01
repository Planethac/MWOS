# Commands

### That is just everything from kernel.c right now.

## Core

No need to be defined. This is the entry point for the kernel.

    kernel_entry():

    vga_entry();

    init_vga();

## Print (Will improve soon)

Prints the String str

    print_string(str);

Prints the Integer int.

    print_int(int);

Goes to the next line

    print_new_line();

Prints a char to the VGA

    print_char();

## Utility

Returns the length of a string.

    strlen(str);

IDK. Probably counts the length of the Int.

    digit_count(int);

Converts your dear int into a string.

    itoa(int, str);

# Required Stuff

- Ubuntu (or any Linux Distro)

- Install packages below with "sudo apt install <package>" from within Distro

- GCC

- qemu-system-x86_64

- grub2-common:i386

- mtools

- binutils

## Install Manually

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libisoburn.html

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libburn.html

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libisofs.html

- Run "./configure" "make" "sudo make install" after unpacking these into separate folders.
