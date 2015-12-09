;************************************************************************
;* HC12 Program:	YourProg - MiniExplanation							*
;* Processor:	MC9S12XDP512											*
;* Xtal Speed:	16 MHz													*
;* Author:		P Ross Taylor											*
;* Date:		LatestRevisionDate										*
;*																		*
;* Details: A more detailed explanation of the program is entered here	*
;*																		*
;************************************************************************

;export symbols
		XDEF 		Entry			;export'Entry' symbol
		ABSENTRY 	Entry			;for absolute assembly: app entry point

;include derivative specific macros
		INCLUDE 'derivative.inc'

;********************************************************************
;*		Equates														*
;********************************************************************


;********************************************************************
;*		Variables													*
;********************************************************************
		ORG			RAMStart		;Address $2000

DATA1:
    DS.B    1
DATA2:
    DS.B    1
ANSWER1:
    DS.B    1
ANSWER2:
    DS.B    1


;********************************************************************
;*		Code Section												*
;********************************************************************
		ORG			ROM_4000Start	;Address $4000 (FLASH)
Entry:
		LDS			#RAMEnd+1		;initialize the stack pointer

Main:
	CLRA			        	; AccA starts out with a known value
	CLRB		        		; AccB starts out with a known value
  LDX     #SIXBYTES 	; IX points to the SIXBYTES block
  LDY     #ANSWER2  	; IY points to the variable ANSWER2
  JSR	  	ADDSIX	  	; Call the ADDSIX subroutine
  
  BRA     *		      	; Stall the program





;********************************************************************
;*		Subroutines													*
;********************************************************************
 ADDTWO:
    PSHA              ; AccA and IX will be messed up by this subroutine,
    PSHX              ; so their original values are saved on the stack
    LDAA    0,X       ; IX has #DATA1 so the DATA1 value goes to AccA
    INX               ; #DATA1 + 1 (== #DATA2) is now in IX,
    ADDA    0,X       ; so the DATA2 value is added to AccA
    INX               ; #DATA2 + 1 (== #ANSWER1) is now in IX,
    STAA    0,X       ; so AccA (== DATA1+DATA2) goes to ANSWER1 
    PULX              ; Original IX comes back
    PULA              ; Original AccA comes back
    RTS               ; the subroutine returns to the calling program


ADDSIX:
;** NEED TO DO STUFF HERE ***************************
;*
;*
;*
;*
;*
;*
;*
;*
;*
;****************************************************
    

;********************************************************************
;*		Interrupt Service Routines											*
;********************************************************************


;********************************************************************
;*		Constants													*
;********************************************************************
		ORG			ROM_C000Start	;second block of ROM
SIXBYTES:
    DC.B    33,46,-25,18,7,10



;********************************************************************
;*		Look-Up Tables												*
;********************************************************************


;********************************************************************
;*		SCI VT100 Strings											*
;********************************************************************


;********************************************************************
;*		Absolute Library Includes									*
;********************************************************************

		;INCLUDE "Your_Lib.inc"


;********************************************************************
;*		Interrupt Vectors											*
;********************************************************************

		ORG			$FFFE
		DC.W		Entry			;Reset Vector