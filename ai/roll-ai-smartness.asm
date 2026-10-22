
/home/dmtf/Downloads/App/arm64/kopie/libil2cpp.so:	file format elf64-littleaarch64

Disassembly of section il2cpp:

0000000003b63274 <__start_il2cpp>:
 667296c: a9be57fe     	stp	x30, x21, [sp, #-0x20]!
 6672970: a9014ff4     	stp	x20, x19, [sp, #0x10]
 6672974: d0011bf5     	adrp	x21, 0x89f0000
 6672978: aa0103f4     	mov	x20, x1
 667297c: 2a0003f3     	mov	w19, w0
 6672980: 396d8ea8     	ldrb	w8, [x21, #0xb63]
 6672984: 370000c8     	tbnz	w8, #0x0, 0x667299c <__start_il2cpp+0x2b0f728>
 6672988: d000efc0     	adrp	x0, 0x846c000
 667298c: f947c400     	ldr	x0, [x0, #0xf88]
 6672990: 974f2737     	bl	0x3a3c66c
 6672994: 52800028     	mov	w8, #0x1                // =1
 6672998: 392d8ea8     	strb	w8, [x21, #0xb63]
 667299c: b4000774     	cbz	x20, 0x6672a88 <__start_il2cpp+0x2b0f814>
 66729a0: f9403680     	ldr	x0, [x20, #0x68]
 66729a4: b4000720     	cbz	x0, 0x6672a88 <__start_il2cpp+0x2b0f814>
 66729a8: d000efd4     	adrp	x20, 0x846c000
 66729ac: 2a1303e1     	mov	w1, w19
 66729b0: aa1f03e2     	mov	x2, xzr
 66729b4: f947c694     	ldr	x20, [x20, #0xf88]
 66729b8: 9401816f     	bl	0x66d2f74 <__start_il2cpp+0x2b6fd00>
 66729bc: f9400288     	ldr	x8, [x20]
 66729c0: aa0003f3     	mov	x19, x0
 66729c4: b940e509     	ldr	w9, [x8, #0xe4]
 66729c8: 35000069     	cbnz	w9, 0x66729d4 <__start_il2cpp+0x2b0f760>
 66729cc: aa0803e0     	mov	x0, x8
 66729d0: 974f2786     	bl	0x3a3c7e8
 66729d4: d0011bf5     	adrp	x21, 0x89f0000
 66729d8: 39641ea8     	ldrb	w8, [x21, #0x907]
 66729dc: 350000c8     	cbnz	w8, 0x66729f4 <__start_il2cpp+0x2b0f780>
 66729e0: d000efc0     	adrp	x0, 0x846c000
 66729e4: f947c400     	ldr	x0, [x0, #0xf88]
 66729e8: 974f2721     	bl	0x3a3c66c
 66729ec: 52800028     	mov	w8, #0x1                // =1
 66729f0: 39241ea8     	strb	w8, [x21, #0x907]
 66729f4: f9400280     	ldr	x0, [x20]
 66729f8: b940e408     	ldr	w8, [x0, #0xe4]
 66729fc: 35000068     	cbnz	w8, 0x6672a08 <__start_il2cpp+0x2b0f794>
 6672a00: 974f277a     	bl	0x3a3c7e8
 6672a04: f9400280     	ldr	x0, [x20]
 6672a08: f9405c08     	ldr	x8, [x0, #0xb8]
 6672a0c: 3940e109     	ldrb	w9, [x8, #0x38]
 6672a10: 340002a9     	cbz	w9, 0x6672a64 <__start_il2cpp+0x2b0f7f0>
 6672a14: b940e409     	ldr	w9, [x0, #0xe4]
 6672a18: 35000089     	cbnz	w9, 0x6672a28 <__start_il2cpp+0x2b0f7b4>
 6672a1c: 974f2773     	bl	0x3a3c7e8
 6672a20: f9400280     	ldr	x0, [x20]
 6672a24: f9405c08     	ldr	x8, [x0, #0xb8]
 6672a28: f9400908     	ldr	x8, [x8, #0x10]
 6672a2c: b40001c8     	cbz	x8, 0x6672a64 <__start_il2cpp+0x2b0f7f0>
 6672a30: b940e409     	ldr	w9, [x0, #0xe4]
 6672a34: 350000c9     	cbnz	w9, 0x6672a4c <__start_il2cpp+0x2b0f7d8>
 6672a38: 974f276c     	bl	0x3a3c7e8
 6672a3c: f9400288     	ldr	x8, [x20]
 6672a40: f9405d08     	ldr	x8, [x8, #0xb8]
 6672a44: f9400908     	ldr	x8, [x8, #0x10]
 6672a48: b4000208     	cbz	x8, 0x6672a88 <__start_il2cpp+0x2b0f814>
 6672a4c: 39404108     	ldrb	w8, [x8, #0x10]
 6672a50: 340000a8     	cbz	w8, 0x6672a64 <__start_il2cpp+0x2b0f7f0>
 6672a54: b40001b3     	cbz	x19, 0x6672a88 <__start_il2cpp+0x2b0f814>
 6672a58: 9100c268     	add	x8, x19, #0x30
 6672a5c: 9100d269     	add	x9, x19, #0x34
 6672a60: 14000004     	b	0x6672a70 <__start_il2cpp+0x2b0f7fc>
 6672a64: b4000133     	cbz	x19, 0x6672a88 <__start_il2cpp+0x2b0f814>
 6672a68: 9100a268     	add	x8, x19, #0x28
 6672a6c: 9100b269     	add	x9, x19, #0x2c
 6672a70: a9414ff4     	ldp	x20, x19, [sp, #0x10]
 6672a74: aa1f03e0     	mov	x0, xzr
 6672a78: bd400100     	ldr	s0, [x8]
 6672a7c: bd400121     	ldr	s1, [x9]
 6672a80: a8c257fe     	ldp	x30, x21, [sp], #0x20
 6672a84: 17fdccb2     	b	0x65e5d4c <__start_il2cpp+0x2a82ad8>
 6672a88: 974f27a3     	bl	0x3a3c914
