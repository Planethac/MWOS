# Commands

### That is just everything from kernel.c right now.

## Core

        kernel_entry():

    No need to be defined. This is the entry point for the kernel.

        vga_entry();
        
        init_vga();

    Same for the Kernel.



## Print (Will improve soon)

        print_string(str);

    Prints the string str.

        print_int(int);

    Prints the Integer int.

        print_new_line();

        print_char();

    No need to call these.

## Utility

        strlen(str);

    Returns the length of a string.

        digit_count();

    IDK. Probably counts the length of the Int.

        itoa();

    Converts your dear int into a string.

# Required Packages

- Ubuntu (or any Linux Distro)

- GCC

- qemu-system-x86_64

- grub2-common:i386

- Install those with "sudo apt install <package>"

## Install Manually

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libisoburn.html

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libburn.html

- https://www.linuxfromscratch.org/blfs/view/svn/multimedia/libisofs.html

- Run "./configure" "make" "sudo make install" after unpacking these into separate folders.
