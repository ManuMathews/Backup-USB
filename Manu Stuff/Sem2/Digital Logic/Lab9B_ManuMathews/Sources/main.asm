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
BINARY:
    DS.B    1
ONECOUNT1:
    DS.B    1
ONECOUNT2:
    DS.B    1
LOOPCOUNT:
    DS.B    1

;********************************************************************
;*		Code Section												*
;********************************************************************
		ORG			ROM_4000Start	;Address $4000 (FLASH)
Entry:
		LDS			#RAMEnd+1		;initialize the stack pointer

Main:
    MOVB   	#%01010101,BINARY
    BSET    BINARY,#%10010110
    BCLR    BINARY,#%01101001
    CLR     ONECOUNT1
    BRCLR   BINARY,#1,NOTBIT0
    INC     ONECOUNT1
NOTBIT0:
    BRCLR   BINARY,#%10,NOTBIT1
    INC     ONECOUNT1
NOTBIT1:
    BRCLR   BINARY,#%100,NOTBIT2
    INC     ONECOUNT1
NOTBIT2:
    BRCLR   BINARY,#%1000,NOTBIT3
    INC     ONECOUNT1
NOTBIT3:
    BRCLR   BINARY,#%10000,NOTBIT4
    INC     ONECOUNT1
NOTBIT4:
    BRCLR   BINARY,#%100000,NOTBIT5
    INC     ONECOUNT1
NOTBIT5:
    BRCLR   BINARY,#%1000000,NOTBIT6
    INC     ONECOUNT1
NOTBIT6:
    BRCLR   BINARY,#%10000000,NOTBIT7
    INC     ONECOUNT1
NOTBIT7:
    CLRA
    LDAB    BINARY
    MOVB    #8,LOOPCOUNT
AGAIN:
    RORB
    ADCA    #0
    DEC     LOOPCOUNT
    BNE     AGAIN
    STAA    ONECOUNT2
    BRA     *





;********************************************************************
;*		Subroutines													*
;********************************************************************


;********************************************************************
;*		Interrupt Service Routines											*
;********************************************************************


;********************************************************************
;*		Constants													*
;********************************************************************
		ORG			ROM_C000Start	;second block of ROM


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