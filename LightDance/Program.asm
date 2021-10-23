
	LIST	p=18F4550		;tell assembler what chip we are using
	include "P18F4550.inc"		;include the defaults for the chip
	;__config 0x3D18			;sets the configuration settings 
					;(oscillator type etc.)

	;config OSC=HS & WDT=OFF & _LVP_OFF & _PWRTE_ON & _CP_OFF
	config FOSC = HS 

	;config LVP_OFF_4L & _PWRT_OFF_2L 

	cblock 	0x20 			;start of general purpose registers
		count1 			;used in delay routine
		count2 			;used in delay routine 
		count3 			;used in delay routine
		count_back
	endc

	org	0x0000			;org sets the origin, 0x0000 for the 16F628,
					;this is where the program starts running	
	

	clrf PORTB ;Initialize PORTA by clearing output data latches
	CLRF LATB ;Alternate method to clear output data latches
	clrf PORTD ;Initialize PORTA by clearing output data latches
	CLRF LATD ;Alternate method to clear output data latches
	
	movlw 	0x00 ; Value used to initialize data direction; in this case all output
	banksel TRISB ; Select bank containing TRISB
	movwf	TRISB ; Set the value to the TRISB
	banksel TRISD ; Select bank containing TRISD
	movwf	TRISD ; Set the value to the TRISD

	
	MOVLW  b'11111110' ; initilization value of PORTB
	movwf  PORTB
	MOVLW  b'10000000' ; initilization value of PORTD
	movwf  PORTD

Loop
	
	;goto Loop
	;call	Delay

	MOVLW  b'10000000' ; initilization value of PORTD
	movwf  PORTD
	
	MOVLW  b'01000000' ; initilization value of PORTD
	movwf  PORTD

	MOVLW  b'00100000' ; initilization value of PORTD
	movwf  PORTD

	MOVLW  b'00010000' ; initilization value of PORTD
	movwf  PORTD


	goto	Loop			;go back and do it again


	

	END