#include "include/kernel.h"
#include "drivers/drivers.h"

//Variables
uint32 vga_index;
static uint32 next_line_index = 1;
uint8 g_fore_color = WHITE, g_back_color = BLUE;
int digit_ascii_codes[10] = {0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39};

uint16 vga_entry(char ch, uint8 fore_color, uint8 back_color) 
{
  uint16 ax = 0;
  uint8 ah = 0, al = 0;

  ah = back_color;
  ah <<= 4;
  ah |= fore_color;
  ax = ah;
  ax <<= 8;
  al = ch;
  ax |= al;

  return ax;
}

//clear video buffer array
void clear_vga_buffer(uint16 **buffer, uint8 fore_color, uint8 back_color)
{
  uint32 i;
  for(i = 0; i < BUFSIZE; i++){
    (*buffer)[i] = vga_entry(NULL, fore_color, back_color);
  }
  next_line_index = 1;
  vga_index = 0;
}

//initialize vga buffer
void init_vga(uint8 fore_color, uint8 back_color)
{
  vga_buffer = (uint16*)VGA_ADDRESS;
  clear_vga_buffer(&vga_buffer, fore_color, back_color);
  g_fore_color = fore_color;
  g_back_color = back_color;
}

void new()
{
  if(next_line_index >= 55){
    next_line_index = 0;
    clear_vga_buffer(&vga_buffer, g_fore_color, g_back_color);
  }
  vga_index = 80*next_line_index;
  next_line_index++;
}

void print_char(char ch)
{
  vga_buffer[vga_index] = vga_entry(ch, g_fore_color, g_back_color);
  vga_index++;
}

void sleep(uint32 timer_count)
{
    while(1){
    asm volatile("nop");
    timer_count--;
    if(timer_count <= 0)
      break;
    }
}

uint8 inb(uint16 port)
{
  uint8 ret;
  asm volatile("inb %1, %0" : "=a"(ret) : "d"(port));
  return ret;
}

void outb(uint16 port, uint8 data)
{
  asm volatile("outb %0, %1" : "=a"(data) : "d"(port));
}

//Remove last Char
void remove_char()
{
	vga_index--;
	char *ch = " ";
  vga_buffer[vga_index] = vga_entry(*ch, g_fore_color, g_back_color);
}

char get_input_keycode()
{
  char ch = 0;
  while((ch = inb(KEYBOARD_PORT)) != 0){
    if(ch > 0)
      return ch;
  }
  return ch;
}

char get_pressed()
{
	char ch = 0;
  while((ch = inb(KEYBOARD_PORT)) != 0){
    if(ch > 0)
      return ch;
  }
  return ch;
  if((ScanCode = inb(KEYBOARD_PORT) & 127) == 127){
  	
  } else {
  	check = 1;
  }
  return check;
}

char get_released()
{
	char check = 0;
  unsigned char ScanCode = inb(0x60);     
  if(ScanCode+0x80){
  	check = 1;
  } else {
  	
  }
  return check;
}

void print_string(char *str)
{
  uint32 index = 0;
  while(str[index]){
    print_char(str[index]);
    index++;
  }
}
void print_int(int num)
{
  char str_num[digit_count(num)+1];
  itoa(num, str_num);
  print_string(str_num);
}

void input(char *str)
{
  char ch = 0;
  char keycode = 0;
  char pressed = 0;
  print_string(str);
  do{
  	keycode = get_input_keycode();
   	if (pressed == 0){
    	if(keycode == KEY_ENTER){
      	new();
      	pressed = 1;
      }else if(keycode == KEY_BACKSPACE){
      	remove_char();
      	pressed = 1;
    	}else{
      	ch = get_ascii_char(keycode);
      	print_char(ch);
      	pressed = 1;
      }
    }
    if (get_released()){
			pressed = 0;
		}
  }while(ch >= 0);
}

void kernel_entry()
{
  init_vga(g_fore_color,g_back_color);

  print_string("Hello World!");
  new();
  input(":> ");
}
