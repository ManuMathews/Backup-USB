-- Copyright (C) 1991-2013 Altera Corporation
-- Your use of Altera Corporation's design tools, logic functions 
-- and other software and tools, and its AMPP partner logic 
-- functions, and any output files from any of the foregoing 
-- (including device programming or simulation files), and any 
-- associated documentation or information are expressly subject 
-- to the terms and conditions of the Altera Program License 
-- Subscription Agreement, Altera MegaCore Function License 
-- Agreement, or other applicable license agreement, including, 
-- without limitation, that your use is for the sole purpose of 
-- programming logic devices manufactured by Altera and sold by 
-- Altera or its authorized distributors.  Please refer to the 
-- applicable agreement for further details.

-- PROGRAM		"Quartus II 64-Bit"
-- VERSION		"Version 13.0.1 Build 232 06/12/2013 Service Pack 1 SJ Web Edition"
-- CREATED		"Thu Dec 03 10:48:32 2015"

LIBRARY ieee;
USE ieee.std_logic_1164.all; 

LIBRARY work;

ENTITY Lab12 IS 
	PORT
	(
		START :  IN  STD_LOGIC;
		Clock :  IN  STD_LOGIC;
		B :  OUT  STD_LOGIC;
		A :  OUT  STD_LOGIC;
		C :  OUT  STD_LOGIC
	);
END Lab12;

ARCHITECTURE bdf_type OF Lab12 IS 

SIGNAL	JKFF_inst12 :  STD_LOGIC;
SIGNAL	SYNTHESIZED_WIRE_9 :  STD_LOGIC;
SIGNAL	SYNTHESIZED_WIRE_10 :  STD_LOGIC;
SIGNAL	SYNTHESIZED_WIRE_11 :  STD_LOGIC;
SIGNAL	SYNTHESIZED_WIRE_2 :  STD_LOGIC;
SIGNAL	JKFF_inst9 :  STD_LOGIC;
SIGNAL	SYNTHESIZED_WIRE_7 :  STD_LOGIC;


BEGIN 
B <= SYNTHESIZED_WIRE_9;
A <= JKFF_inst12;
C <= JKFF_inst9;
SYNTHESIZED_WIRE_10 <= '1';



SYNTHESIZED_WIRE_7 <= JKFF_inst12 OR SYNTHESIZED_WIRE_9;



SYNTHESIZED_WIRE_2 <= NOT(SYNTHESIZED_WIRE_9);



PROCESS(Clock,SYNTHESIZED_WIRE_10,START)
VARIABLE synthesized_var_for_JKFF_inst12 : STD_LOGIC;
BEGIN
IF (SYNTHESIZED_WIRE_10 = '0') THEN
	synthesized_var_for_JKFF_inst12 := '0';
ELSIF (START = '0') THEN
	synthesized_var_for_JKFF_inst12 := '1';
ELSIF (RISING_EDGE(Clock)) THEN
	synthesized_var_for_JKFF_inst12 := (NOT(synthesized_var_for_JKFF_inst12) AND SYNTHESIZED_WIRE_2) OR (synthesized_var_for_JKFF_inst12 AND (NOT(SYNTHESIZED_WIRE_11)));
END IF;
	JKFF_inst12 <= synthesized_var_for_JKFF_inst12;
END PROCESS;


SYNTHESIZED_WIRE_11 <= NOT(JKFF_inst9);



PROCESS(Clock,START,SYNTHESIZED_WIRE_10)
VARIABLE synthesized_var_for_SYNTHESIZED_WIRE_9 : STD_LOGIC;
BEGIN
IF (START = '0') THEN
	synthesized_var_for_SYNTHESIZED_WIRE_9 := '0';
ELSIF (SYNTHESIZED_WIRE_10 = '0') THEN
	synthesized_var_for_SYNTHESIZED_WIRE_9 := '1';
ELSIF (RISING_EDGE(Clock)) THEN
	synthesized_var_for_SYNTHESIZED_WIRE_9 := (NOT(synthesized_var_for_SYNTHESIZED_WIRE_9) AND SYNTHESIZED_WIRE_11) OR (synthesized_var_for_SYNTHESIZED_WIRE_9 AND (NOT(SYNTHESIZED_WIRE_11)));
END IF;
	SYNTHESIZED_WIRE_9 <= synthesized_var_for_SYNTHESIZED_WIRE_9;
END PROCESS;


PROCESS(Clock,SYNTHESIZED_WIRE_10,START)
VARIABLE synthesized_var_for_JKFF_inst9 : STD_LOGIC;
BEGIN
IF (SYNTHESIZED_WIRE_10 = '0') THEN
	synthesized_var_for_JKFF_inst9 := '0';
ELSIF (START = '0') THEN
	synthesized_var_for_JKFF_inst9 := '1';
ELSIF (RISING_EDGE(Clock)) THEN
	synthesized_var_for_JKFF_inst9 := (NOT(synthesized_var_for_JKFF_inst9) AND SYNTHESIZED_WIRE_10) OR (synthesized_var_for_JKFF_inst9 AND (NOT(SYNTHESIZED_WIRE_7)));
END IF;
	JKFF_inst9 <= synthesized_var_for_JKFF_inst9;
END PROCESS;


END bdf_type;