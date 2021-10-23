   /*
   Assignment: Buzzer Ringing
   Name : Md. Mahedee Hasan
   Student no: 0412312013
   Dept: ICT,BUET

   */

#include <18F4550.h>
#FUSES HS, nowdt, noprotect,nolvp							//High speed OSC
#use delay(clock=20000000)
#use standard_io(B)
#define use_port_B_lcd TRUE

#include<lcd.c>


void main(void)
{   
	set_tris_c(0xFF); //Set for C as input

	lcd_init();
		while(1)
		{
			delay_ms(100);
			if(input(PIN_A0)==1)
			{
			 	output_high(PIN_A1);
		   	 	printf(lcd_putc,"\f Buzzer On");
			}
		   	else
			{
		   	  printf(lcd_putc,"\f Buzzer Off");
			  output_low(PIN_A1);
			}
		   	 
		}

}
