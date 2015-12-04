// Copyright (C) 1991-2013 Altera Corporation
// Your use of Altera Corporation's design tools, logic functions 
// and other software and tools, and its AMPP partner logic 
// functions, and any output files from any of the foregoing 
// (including device programming or simulation files), and any 
// associated documentation or information are expressly subject 
// to the terms and conditions of the Altera Program License 
// Subscription Agreement, Altera MegaCore Function License 
// Agreement, or other applicable license agreement, including, 
// without limitation, that your use is for the sole purpose of 
// programming logic devices manufactured by Altera and sold by 
// Altera or its authorized distributors.  Please refer to the 
// applicable agreement for further details.

// PROGRAM		"Quartus II 64-Bit"
// VERSION		"Version 13.0.1 Build 232 06/12/2013 Service Pack 1 SJ Web Edition"
// CREATED		"Thu Dec 03 10:43:03 2015"

module Lab12(
	START,
	Clock,
	B,
	A,
	C
);


input wire	START;
input wire	Clock;
output wire	B;
output wire	A;
output wire	C;

reg	JKFF_inst12;
reg	SYNTHESIZED_WIRE_9;
wire	SYNTHESIZED_WIRE_10;
wire	SYNTHESIZED_WIRE_11;
wire	SYNTHESIZED_WIRE_2;
reg	JKFF_inst9;
wire	SYNTHESIZED_WIRE_7;

assign	B = SYNTHESIZED_WIRE_9;
assign	A = JKFF_inst12;
assign	C = JKFF_inst9;
assign	SYNTHESIZED_WIRE_10 = 1;



assign	SYNTHESIZED_WIRE_7 = JKFF_inst12 | SYNTHESIZED_WIRE_9;


assign	SYNTHESIZED_WIRE_2 =  ~SYNTHESIZED_WIRE_9;


always@(posedge Clock or negedge SYNTHESIZED_WIRE_10 or negedge START)
begin
if (!SYNTHESIZED_WIRE_10)
	begin
	JKFF_inst12 <= 0;
	end
else
	begin
if (!START)
	begin
	JKFF_inst12 <= 1;
	end
else
	begin
	JKFF_inst12 <= ~JKFF_inst12 & SYNTHESIZED_WIRE_2 | JKFF_inst12 & ~SYNTHESIZED_WIRE_11;
	end
	end
end

assign	SYNTHESIZED_WIRE_11 =  ~JKFF_inst9;


always@(posedge Clock or negedge START or negedge SYNTHESIZED_WIRE_10)
begin
if (!START)
	begin
	SYNTHESIZED_WIRE_9 <= 0;
	end
else
	begin
if (!SYNTHESIZED_WIRE_10)
	begin
	SYNTHESIZED_WIRE_9 <= 1;
	end
else
	begin
	SYNTHESIZED_WIRE_9 <= ~SYNTHESIZED_WIRE_9 & SYNTHESIZED_WIRE_11 | SYNTHESIZED_WIRE_9 & ~SYNTHESIZED_WIRE_11;
	end
	end
end


always@(posedge Clock or negedge SYNTHESIZED_WIRE_10 or negedge START)
begin
if (!SYNTHESIZED_WIRE_10)
	begin
	JKFF_inst9 <= 0;
	end
else
	begin
if (!START)
	begin
	JKFF_inst9 <= 1;
	end
else
	begin
	JKFF_inst9 <= ~JKFF_inst9 & SYNTHESIZED_WIRE_10 | JKFF_inst9 & ~SYNTHESIZED_WIRE_7;
	end
	end
end


endmodule
