
/home/dmtf/Downloads/App/arm64/kopie/libil2cpp.so:	file format elf64-littleaarch64

Disassembly of section il2cpp:

0000000003b63274 <__start_il2cpp>:
 68839d4: f81c0ffe     	str	x30, [sp, #-0x40]!
 68839d8: a9015ff8     	stp	x24, x23, [sp, #0x10]
 68839dc: a90257f6     	stp	x22, x21, [sp, #0x20]
 68839e0: a9034ff4     	stp	x20, x19, [sp, #0x30]
 68839e4: d0010b76     	adrp	x22, 0x89f1000
 68839e8: b000df98     	adrp	x24, 0x8474000
 68839ec: b000df97     	adrp	x23, 0x8474000
 68839f0: 397fcac8     	ldrb	w8, [x22, #0xff2]
 68839f4: f941db18     	ldr	x24, [x24, #0x3b0]
 68839f8: f94536f7     	ldr	x23, [x23, #0xa68]
 68839fc: aa0203f5     	mov	x21, x2
 6883a00: aa0103f4     	mov	x20, x1
 6883a04: aa0003f3     	mov	x19, x0
 6883a08: 37000128     	tbnz	w8, #0x0, 0x6883a2c <__start_il2cpp+0x2d207b8>
 6883a0c: b000df80     	adrp	x0, 0x8474000
 6883a10: f9453400     	ldr	x0, [x0, #0xa68]
 6883a14: 9746e316     	bl	0x3a3c66c
 6883a18: b000df80     	adrp	x0, 0x8474000
 6883a1c: f941d800     	ldr	x0, [x0, #0x3b0]
 6883a20: 9746e313     	bl	0x3a3c66c
 6883a24: 52800028     	mov	w8, #0x1                // =1
 6883a28: 393fcac8     	strb	w8, [x22, #0xff2]
 6883a2c: f9400300     	ldr	x0, [x24]
 6883a30: 9746e3b5     	bl	0x3a3c904
 6883a34: f94002e1     	ldr	x1, [x23]
 6883a38: aa0003f6     	mov	x22, x0
 6883a3c: 9784a1be     	bl	0x49ac134 <__start_il2cpp+0xe48ec0>
 6883a40: aa1303e0     	mov	x0, x19
 6883a44: aa1603e1     	mov	x1, x22
 6883a48: f8018c16     	str	x22, [x0, #0x18]!
 6883a4c: 9746e2f3     	bl	0x3a3c618
 6883a50: f9400300     	ldr	x0, [x24]
 6883a54: 9746e3ac     	bl	0x3a3c904
 6883a58: f94002e1     	ldr	x1, [x23]
 6883a5c: aa0003f6     	mov	x22, x0
 6883a60: 9784a1b5     	bl	0x49ac134 <__start_il2cpp+0xe48ec0>
 6883a64: aa1303e0     	mov	x0, x19
 6883a68: aa1603e1     	mov	x1, x22
 6883a6c: f8020c16     	str	x22, [x0, #0x20]!
 6883a70: 9746e2ea     	bl	0x3a3c618
 6883a74: aa1303e0     	mov	x0, x19
 6883a78: aa1f03e1     	mov	x1, xzr
 6883a7c: 945739c4     	bl	0x7e5218c <__start_il2cpp+0x42eef18>
 6883a80: b40002b4     	cbz	x20, 0x6883ad4 <__start_il2cpp+0x2d20860>
 6883a84: bd405e80     	ldr	s0, [x20, #0x5c]
 6883a88: f8028e75     	str	x21, [x19, #0x28]!
 6883a8c: aa1303e0     	mov	x0, x19
 6883a90: aa1503e1     	mov	x1, x21
 6883a94: bc1e8260     	stur	s0, [x19, #-0x18]
 6883a98: 9746e2e0     	bl	0x3a3c618
 6883a9c: ad410282     	ldp	q2, q0, [x20, #0x20]
 6883aa0: 91002260     	add	x0, x19, #0x8
 6883aa4: f9402288     	ldr	x8, [x20, #0x40]
 6883aa8: 3dc00681     	ldr	q1, [x20, #0x10]
 6883aac: aa1f03e1     	mov	x1, xzr
 6883ab0: a94257f6     	ldp	x22, x21, [sp, #0x20]
 6883ab4: f9001e68     	str	x8, [x19, #0x38]
 6883ab8: a9415ff8     	ldp	x24, x23, [sp, #0x10]
 6883abc: 3c828260     	stur	q0, [x19, #0x28]
 6883ac0: 3c818262     	stur	q2, [x19, #0x18]
 6883ac4: 3c808261     	stur	q1, [x19, #0x8]
 6883ac8: a9434ff4     	ldp	x20, x19, [sp, #0x30]
 6883acc: f84407fe     	ldr	x30, [sp], #0x40
 6883ad0: 1746e2d2     	b	0x3a3c618
 6883ad4: 9746e390     	bl	0x3a3c914
