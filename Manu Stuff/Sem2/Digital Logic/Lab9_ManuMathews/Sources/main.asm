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
	ORG		  RAMStart		;Address $2000
COUNT:
    DS.B    1
SUM1:
    DS.B    1
    
SUM2:
    DS.B    1

;********************************************************************
;*		Code Section												*
;********************************************************************
		ORG			ROM_4000Start	;Address $4000 (FLASH)
Entry:
		LDS			#RAMEnd+1		;initialize the stack pointer

Main:
    MOVB    #10,COUNT   ; Start the COUNT variable at 10
    CLR     SUM1        ; Start the SUM1 variable at 0
    CLR     SUM2        ; Start the SUM2 variable at 0

    LDX     #TABLE      ; Make IX point to the first TABLE entry
AGAIN:                  ; This is the repetition branch target
    LDAA    X           ; Load AccA with the current TABLE entry
    ADDA    SUM1        ; Add the current SUM1 contents to AccA
    STAA    SUM1        ; Update the SUM1 value after the addition
    
    LDAA    X           ; Load AccA with the current TABLE entry again
    CMPA    #7          ; How does the AccA value compare to 7?
    BLE     AROUND      ; If AccA <= 7 skip the next two instructions
    ADDA    SUM2        ; Add the current SUM2 contents to AccA
    STAA    SUM2        ; Update the SUM2 value after the addition
AROUND:                 ; This is the BLE target

    INX                 ; IX points to the next TABLE entry
    DEC     COUNT       ; COUNT-- counts the completed process
    BNE     AGAIN       ; Go do another pass if COUNT has not reached 0
    BRA     *           ; Stall here until the debugger stops






;********************************************************************
;*		Subroutines													*
;********************************************************************


;********************************************************************
;*		Interrupt Service Routines											*
;********************************************************************


;********************************************************************
;*		Constants                                                   *
;********************************************************************
		ORG			ROM_C000Start	; Address $C000 (EEPROM)
TABLE:
    DC.B    22,-5,30,14,-18,7,0,19,42,-27


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