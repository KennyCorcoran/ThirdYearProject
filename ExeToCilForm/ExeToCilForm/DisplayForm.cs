using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ExeToCilForm
{
    public partial class DisplayForm : Form
    {
        private Form1 exeFormRef;
        private List<string> input;
        public DisplayForm()
        {
            InitializeComponent();
        }
        public DisplayForm(List<string> cilFile, Form1 exeForm)
        {
            InitializeComponent();
            input = cilFile;
            addInputToTextBox();
            exeFormRef = exeForm;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            exeFormRef.Close();
        }

        private void convertToReadableButton_Click(object sender, EventArgs e)
        {
            convertToReadable();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
        }
        // Converts text from addInputTextBox into outputTextBox and shows IL in the strings and trims all the useless words.
        private void convertToReadable()
        {
            bool useNext = false;
            foreach (string line in richTextBox1.Lines)
            {
                if(useNext)
                {
                    outputRichTextBox.AppendText(line.Trim() + " { " + Environment.NewLine);
                    useNext = false;
                }

                if (line.Contains(".method") || line.Contains(".Method"))
                {
                    string methodName = line.Trim();
                    outputRichTextBox.AppendText(methodName);
                    useNext = true;
                }


                if (line.Contains("IL_") || line.Contains("il_"))
                {
                    string trimmed = line.Trim().Substring(3);

                    string valueDescript = switchCase(trimmed.Split()[2]);

                    string fullLine = trimmed.Split()[0] + " " + trimmed.Split()[2] + "  \t:\t" + valueDescript + " " + Environment.NewLine;

                    outputRichTextBox.AppendText(fullLine.Replace("!", "!" + Environment.NewLine + " } --End Method--" + Environment.NewLine));
                } 
            }
        }
            // Displays the exe file in a string and creates a newline for each string.
            private void addInputToTextBox()
            {
                foreach (string line in input)
                {
                    richTextBox1.AppendText(line + Environment.NewLine);
                }
            }

            private void goBackButton_Click(object sender, EventArgs e)
            {
                showExeForm();
                this.Close();
            }

            private void showExeForm()
            {
                exeFormRef.Show();
            }
        
            // Switch statement for all of the opcodes and descriptions.
            private string switchCase(string input)
            {
                string valueDescript = "";
                switch (input)
                {
                        case "add":
                            valueDescript = "Add two values, returning a new value.";
                            break;
                        case "add.ovf":
                            valueDescript = "Add signed integer values with overflow check.";
                            break;
                        case "add.ovf.un":
                            valueDescript = "Add unsigned integer values with overflow check.";
                            break;
                        case "and":
                            valueDescript = "Bitwise AND of two integral values, returns an integral value.";
                            break;
                        case "arglist":
                            valueDescript = "Return argument list handle for the current method.";
                            break;
                        case "beq":
                            valueDescript = "Branch to target if equal.";
                            break;
                        case "beq.s":
                            valueDescript = "Branch to target if equal, short form.";
                            break;
                        case "bge":
                            valueDescript = "Branch to target if greater than or equal to, short form.";
                            break;
                        case "bge.s":
                            valueDescript = "Branch to target if greater than or equal to, short form.";
                            break;
                        case "bge.un":
                            valueDescript = "Branch to target if greater than or equal to (unsigned or unordered).";
                            break;
                        case "bge.un.s":
                            valueDescript = "Branch to target if greater than or equal to (unsigned or unordered), short form";
                            break;
                        case "bgt":
                            valueDescript = "Branch to target if greater than.";
                            break;
                        case "bgt.s":
                            valueDescript = "Branch to target if greater than, short form.";
                            break;
                        case "bgt.un":
                            valueDescript = "Branch to target if greater than (unsigned or unordered).";
                            break;
                        case "bgt.un.s":
                            valueDescript = "Branch to target if greater than (unsigned or unordered), short form.";
                            break;
                        case "ble":
                            valueDescript = "Branch to target if less than or equal to.";
                            break;
                        case "ble.s":
                            valueDescript = "Branch to target if less than or equal to, short form.";
                            break;
                        case "ble.un":
                            valueDescript = "Branch to target if less than or equal to (unsigned or unordered).";
                            break;
                        case "ble.un.s":
                            valueDescript = "Branch to target if less than or equal to (unsigned or unordered), short form";
                            break;
                        case "blt":
                            valueDescript = "Branch to target if less than.";
                            break;
                        case "blt.s":
                            valueDescript = "Branch to target if less than, short form.	";
                            break;
                        case "blt.un":
                            valueDescript = "Branch to target if less than (unsigned or unordered).";
                            break;
                        case "blt.un.s":
                            valueDescript = "Branch to target if less than (unsigned or unordered), short form.";
                            break;
                        case "bne.un":
                            valueDescript = "Branch to target if unequal or unordered.";
                            break;
                        case "bne.un.s":
                            valueDescript = "Branch to target if unequal or unordered, short form.";
                            break;
                        case "box":
                            valueDescript = "Convert a boxable value to its boxed form";
                            break;
                        case "br":
                            valueDescript = "Branch to target.";
                            break;
                        case "br.s":
                            valueDescript = "Branch to target, short form.";
                            break;
                        case "break":
                            valueDescript = "Inform a debugger that a breakpoint has been reached.";
                            break;
                        case "brfalse":
                            valueDescript = "Branch to target if value is zero (false).";
                            break;
                        case "brfalse.s":
                            valueDescript = "Branch to target if value is zero (false), short form.";
                            break;
                        case "brinst":
                            valueDescript = "Branch to target if value is a non-null object reference (alias for brtrue).";
                            break;
                        case "brinst.s":
                            valueDescript = "Branch to target if value is a non-null object reference, short form (alias for brtrue.s).";
                            break;
                        case "brnull":
                            valueDescript = "Branch to target if value is null (alias for brfalse).";
                            break;
                        case "brnull.s":
                            valueDescript = "Branch to target if value is null (alias for brfalse.s), short form.";
                            break;
                        case "brtrue":
                            valueDescript = "Branch to target if value is non-zero (true).";
                            break;
                        case "brtrue.s":
                            valueDescript = "Branch to target if value is non-zero (true), short form.";
                            break;
                        case "brzero":
                            valueDescript = "Branch to target if value is zero (alias for brfalse).";
                            break;
                        case "brzero.s":
                            valueDescript = "Branch to target if value is zero (alias for brfalse.s), short form.";
                            break;
                        case "call":
                            valueDescript = "Call method described by method.";
                            break;
                        case "calli":
                            valueDescript = "Call method indicated on the stack with arguments described by callsitedescr.";
                            break;
                        case "callvirt":
                            valueDescript = "Call a method associated with an object.";
                            break;
                        case "castclass":
                            valueDescript = "Cast obj to class.";
                            break;
                        case "ceq":
                            valueDescript = "Push 1 (of type int32) if value1 equals value2, else push 0.";
                            break;
                        case "cgt":
                            valueDescript = "Push 1 (of type int32) if value1 > value2, else push 0.";
                            break;
                        case "cgt.un":
                            valueDescript = "Push 1 (of type int32) if value1 > value2, unsigned or unordered, else push 0.";
                            break;
                        case "ckfinite":
                            valueDescript = "Throw ArithmeticException if value is not a finite number.";
                            break;
                        case "clt":
                            valueDescript = "Push 1 (of type int32) if value1 < value2, else push 0.";
                            break;
                        case "clt.un":
                            valueDescript = "Push 1 (of type int32) if value1 < value2, unsigned or unordered, else push 0.";
                            break;
                        case "constrained.":
                            valueDescript = "Call a virtual method on a type constrained to be type T";
                            break;
                        case "conv.i":
                            valueDescript = "Convert to native int, pushing native int on stack.";
                            break;
                        case "conv.i1":
                            valueDescript = "Convert to int8, pushing int32 on stack.";
                            break;
                        case "conv.i2":
                            valueDescript = "Convert to int16, pushing int32 on stack.";
                            break;
                        case "conv.i4":
                            valueDescript = "Convert to int32, pushing int32 on stack.";
                            break;
                        case "conv.ovf.i":
                            valueDescript = "Convert to a native int (on the stack as native int) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i.un":
                            valueDescript = "Convert unsigned to a native int (on the stack as native int) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i1":
                            valueDescript = "Convert to an int8 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i1.un":
                            valueDescript = "Convert unsigned to an int8 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i2":
                            valueDescript = "Convert to an int16 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i2.un":
                            valueDescript = "Convert unsigned to an int16 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i4":
                            valueDescript = "Convert to an int32 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i4.un":
                            valueDescript = "Convert unsigned to an int32 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i8":
                            valueDescript = "Convert to an int64 (on the stack as int64) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.i8.un":
                            valueDescript = "Convert unsigned to an int64 (on the stack as int64) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u":
                            valueDescript = "Convert to a native unsigned int (on the stack as native int) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u.un":
                            valueDescript = "Convert unsigned to a native unsigned int (on the stack as native int) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u1":
                            valueDescript = "Convert to an unsigned int8 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u1.un":
                            valueDescript = "Convert unsigned to an unsigned int8 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u2":
                            valueDescript = "Convert to an unsigned int16 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u2.un":
                            valueDescript = "Convert unsigned to an unsigned int16 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u4":
                            valueDescript = "Convert to an unsigned int32 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u4.un":
                            valueDescript = "Convert unsigned to an unsigned int32 (on the stack as int32) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u8":
                            valueDescript = "Convert to an unsigned int64 (on the stack as int64) and throw an exception on overflow.";
                            break;
                        case "conv.ovf.u8.un":
                            valueDescript = "Convert unsigned to an unsigned int64 (on the stack as int64) and throw an exception on overflow.";
                            break;
                        case "conv.r.un":
                            valueDescript = "Convert unsigned integer to floating-point, pushing F on stack.";
                            break;
                        case "conv.r4":
                            valueDescript = "Convert to float32, pushing F on stack.";
                            break;
                        case "conv.r8":
                            valueDescript = "Convert to float64, pushing F on stack.";
                            break;
                        case "conv.u":
                            valueDescript = "Convert to native unsigned int, pushing native int on stack.";
                            break;
                        case "conv.u1":
                            valueDescript = "Convert to unsigned int8, pushing int32 on stack.";
                            break;
                        case "conv.u2":
                            valueDescript = "Convert to unsigned int16, pushing int32 on stack.";
                            break;
                        case "conv.u4":
                            valueDescript = "Convert to unsigned int32, pushing int32 on stack.";
                            break;
                        case "conv.u8":
                            valueDescript = "Convert to unsigned int64, pushing int64 on stack.";
                            break;
                        case "cpblk":
                            valueDescript = "Copy data from memory to memory.";
                            break;
                        case "cpobj":
                            valueDescript = "Copy a value type from src to dest.";
                            break;
                        case "div":
                            valueDescript = "Divide two values to return a quotient or floating-point result.";
                            break;
                        case "div.un":
                            valueDescript = "Divide two values, unsigned, returning a quotient.";
                            break;
                        case "dup":
                            valueDescript = "Duplicate the value on the top of the stack.";
                            break;
                        case "endfault":
                            valueDescript = "End fault clause of an exception block.";
                            break;
                        case "endfilter":
                            valueDescript = "End an exception handling filter clause.";
                            break;
                        case "endfinally":
                            valueDescript = "End finally clause of an exception block.";
                            break;
                        case "initblk":
                            valueDescript = "Set all bytes in a block of memory to a given byte value.";
                            break;
                        case "initobj":
                            valueDescript = "Initialize the value at address dest.";
                            break;
                        case "isinst":
                            valueDescript = "Test if obj is an instance of class, returning null or an instance of that class or interface.";
                            break;
                        case "jmp":
                            valueDescript = "Exit current method and jump to the specified method.";
                            break;
                        case "ldarg":
                            valueDescript = "Load argument numbered num onto the stack.";
                            break;
                        case "ldarg.0":
                            valueDescript = "Load argument 0 onto the stack.";
                            break;
                        case "ldarg.1":
                            valueDescript = "Load argument 1 onto the stack.";
                            break;
                        case "ldarg.2":
                            valueDescript = "Load argument 2 onto the stack.";
                            break;
                        case "ldarg.3":
                            valueDescript = "Load argument 3 onto the stack.";
                            break;
                        case "ldarg.s":
                            valueDescript = "Load argument numbered num onto the stack, short form.";
                            break;
                        case "ldarga":
                            valueDescript = "Fetch the address of argument argNum.";
                            break;
                        case "ldarga.s":
                            valueDescript = "Fetch the address of argument argNum, short form.";
                            break;
                        case "ldc.i4":
                            valueDescript = "Push num of type int32 onto the stack as int32.";
                            break;
                        case "ldc.i4.0":
                            valueDescript = "Push 0 onto the stack as int32.";
                            break;
                        case "ldc.i4.1":
                            valueDescript = "Push 1 onto the stack as int32.";
                            break;
                        case "ldc.i4.2":
                            valueDescript = "Push 2 onto the stack as int32.";
                            break;
                        case "ldc.i4.3":
                            valueDescript = "Push 3 onto the stack as int32.";
                            break;
                        case "ldc.i4.4":
                            valueDescript = "Push 4 onto the stack as int32.";
                            break;
                        case "ldc.i4.5":
                            valueDescript = "Push 5 onto the stack as int32.";
                            break;
                        case "ldc.i4.6":
                            valueDescript = "Push 6 onto the stack as int32.";
                            break;
                        case "ldc.i4.7":
                            valueDescript = "Push 7 onto the stack as int32.";
                            break;
                        case "ldc.i4.8":
                            valueDescript = "Push 8 onto the stack as int32.";
                            break;
                        case "ldc.i4.m1":
                            valueDescript = "Push -1 onto the stack as int32.";
                            break;
                        case "ldc.i4.M1":
                            valueDescript = "Push -1 onto the stack as int32 (alias for ldc.i4.m1).";
                            break;
                        case "ldc.i4.s":
                            valueDescript = "Push num onto the stack as int32, short form.";
                            break;
                        case "ldc.i8":
                            valueDescript = "Push num of type int64 onto the stack as int64.";
                            break;
                        case "ldc.r4":
                            valueDescript = "Push num of type float32 onto the stack as F.";
                            break;
                        case "ldc.r8":
                            valueDescript = "Push num of type float64 onto the stack as F.";
                            break;
                        case "ldelem":
                            valueDescript = "Load the element at index onto the top of the stack.";
                            break;
                        case "ldelem.i":
                            valueDescript = "Load the element with type native int at index onto the top of the stack as a native int.";
                            break;
                        case "ldelem.i1":
                            valueDescript = "Load the element with type int8 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.i2":
                            valueDescript = "Load the element with type int16 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.i4":
                            valueDescript = "Load the element with type int32 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.i8":
                            valueDescript = "Load the element with type int64 at index onto the top of the stack as an int64.";
                            break;
                        case "ldelem.r4":
                            valueDescript = "Load the element with type float32 at index onto the top of the stack as an F";
                            break;
                        case "ldelem.r8":
                            valueDescript = "Load the element with type float64 at index onto the top of the stack as an F.";
                            break;
                        case "ldelem.ref":
                            valueDescript = "Load the element at index onto the top of the stack as an O. The type of the O is the same as the element type of the array pushed on the CIL stack.";
                            break;
                        case "ldelem.u1":
                            valueDescript = "Load the element with type unsigned int8 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.u2":
                            valueDescript = "Load the element with type unsigned int16 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.u4":
                            valueDescript = "Load the element with type unsigned int32 at index onto the top of the stack as an int32.";
                            break;
                        case "ldelem.u8":
                            valueDescript = "Load the element with type unsigned int64 at index onto the top of the stack as an int64 (alias for ldelem.i8).";
                            break;
                        case "ldelema":
                            valueDescript = "Load the address of element at index onto the top of the stack.";
                            break;
                        case "ldfld":
                            valueDescript = "Push the value of field of object (or value type) obj, onto the stack.";
                            break;
                        case "ldflda":
                            valueDescript = "Push the address of field of object obj on the stack.";
                            break;
                        case "ldftn":
                            valueDescript = "Push a pointer to a method referenced by method, on the stack.";
                            break;
                        case "ldind.i":
                            valueDescript = "Indirect load value of type native int as native int on the stack";
                            break;
                        case "ldind.i1":
                            valueDescript = "Indirect load value of type int8 as int32 on the stack.";
                            break;
                        case "ldind.i2":
                            valueDescript = "Indirect load value of type int16 as int32 on the stack.";
                            break;
                        case "ldind.i4":
                            valueDescript = "Indirect load value of type int32 as int32 on the stack.";
                            break;
                        case "ldind.i8":
                            valueDescript = "Indirect load value of type int64 as int64 on the stack.";
                            break;
                        case "ldind.r4":
                            valueDescript = "Indirect load value of type float32 as F on the stack.";
                            break;
                        case "ldind.r8":
                            valueDescript = "Indirect load value of type float64 as F on the stack.";
                            break;
                        case "ldind.ref":
                            valueDescript = "Indirect load value of type object ref as O on the stack.";
                            break;
                        case "ldind.u1":
                            valueDescript = "Indirect load value of type unsigned int8 as int32 on the stack";
                            break;
                        case "ldind.u2":
                            valueDescript = "Indirect load value of type unsigned int16 as int32 on the stack";
                            break;
                        case "ldind.u4":
                            valueDescript = "Indirect load value of type unsigned int32 as int32 on the stack";
                            break;
                        case "ldind.u8":
                            valueDescript = "Indirect load value of type unsigned int64 as int64 on the stack (alias for ldind.i8).";
                            break;
                        case "ldlen":
                            valueDescript = "Push the length (of type native unsigned int) of array on the stack.";
                            break;
                        case "ldloc":
                            valueDescript = "Load local variable of index indx onto stack.";
                            break;
                        case "ldloc.0":
                            valueDescript = "Load local variable 0 onto stack.";
                            break;
                        case "ldloc.1":
                            valueDescript = "Load local variable 1 onto stack.";
                            break;
                        case "ldloc.2":
                            valueDescript = "Load local variable 2 onto stack.";
                            break;
                        case "ldloc.3":
                            valueDescript = "Load local variable 3 onto stack.";
                            break;
                        case "ldloc.s":
                            valueDescript = "Load local variable of index indx onto stack, short form.";
                            break;
                        case "ldloca":
                            valueDescript = "Load address of local variable with index indx.";
                            break;
                        case "ldloca.s":
                            valueDescript = "Load address of local variable with index indx, short form.";
                            break;
                        case "ldnull":
                            valueDescript = "Push a null reference on the stack.";
                            break;
                        case "ldobj":
                            valueDescript = "Copy the value stored at address src to the stack.";
                            break;
                        case "ldsfld":
                            valueDescript = "Push the value of the static field on the stack.";
                            break;
                        case "ldsflda":
                            valueDescript = "Push the address of the static field, field, on the stack.";
                            break;
                        case "ldstr":
                            valueDescript = "Push a string object for the literal string.";
                            break;
                        case "ldtoken":
                            valueDescript = "Convert metadata token to its runtime representation.";
                            break;
                        case "ldvirtftn ":
                            valueDescript = "Push address of virtual method on the stack.";
                            break;
                        case "leave":
                            valueDescript = "Exit a protected region of code.";
                            break;
                        case "leave.s":
                            valueDescript = "Exit a protected region of code, short form.";
                            break;
                        case "localloc":
                            valueDescript = "Allocate space from the local memory pool.";
                            break;
                        case "mkrefany":
                            valueDescript = "Push a typed reference to ptr of type class onto the stack.";
                            break;
                        case "mul":
                            valueDescript = "Multiply values.";
                            break;
                        case "mul.ovf":
                            valueDescript = "Multiply signed integer values. Signed result shall fit in same size";
                            break;
                        case "mul.ovf.un":
                            valueDescript = "Multiply unsigned integer values. Unsigned result shall fit in same size";
                            break;
                        case "neg":
                            valueDescript = "Negate value.";
                            break;
                        case "newarr":
                            valueDescript = "Create a new array with elements of type etype.";
                            break;
                        case "newobj":
                            valueDescript = "Allocate an uninitialized object or value type and call ctor.";
                            break;
                        case "no.":
                            valueDescript = "The specified fault check(s) normally performed as part of the execution of the subsequent instruction can/shall be skipped.";
                            break;
                        case "nop":
                            valueDescript = "Do nothing (No operation).";
                            break;
                        case "not":
                            valueDescript = "Bitwise complement (logical not).";
                            break;
                        case "or":
                            valueDescript = "Bitwise OR of two integer values, returns an integer.";
                            break;
                        case "pop":
                            valueDescript = "Pop value from the stack.";
                            break;
                        case "readonly.":
                            valueDescript = "Specify that the subsequent array address operation performs no type check at runtime, and that it returns a controlled-mutability managed pointer";
                            break;
                        case "refanytype":
                            valueDescript = "Push the type token stored in a typed reference.";
                            break;
                        case "refanyval":
                            valueDescript = "Push the address stored in a typed reference.";
                            break;
                        case "rem":
                            valueDescript = "Remainder when dividing one value by another.";
                            break;
                        case "rem.un":
                            valueDescript = "Remainder when dividing one unsigned value by another.";
                            break;
                        case "ret":
                            valueDescript = "Return from method, possibly with a value!";
                            break;
                        case "rethrow":
                            valueDescript = "Rethrow the current exception.";
                            break;
                        case "shl":
                            valueDescript = "Shift an integer left (shifting in zeros), return an integer.";
                            break;
                        case "shr":
                            valueDescript = "Shift an integer right (shift in sign), return an integer.";
                            break;
                        case "shr.un":
                            valueDescript = "Shift an integer right (shift in zero), return an integer.";
                            break;
                        case "sizeof":
                            valueDescript = "Push the size, in bytes, of a type as an unsigned int32.";
                            break;
                        case "starg":
                            valueDescript = "Store value to the argument numbered num.";
                            break;
                        case "starg.s":
                            valueDescript = "Store value to the argument numbered num, short form.";
                            break;
                        case "stelem":
                            valueDescript = "Replace array element at index with the value on the stack";
                            break;
                        case "stelem.i":
                            valueDescript = "Replace array element at index with the i value on the stack.";
                            break;
                        case "stelem.i1":
                            valueDescript = "Replace array element at index with the int8 value on the stack.";
                            break;
                        case "stelem.i2":
                            valueDescript = "Replace array element at index with the int16 value on the stack.";
                            break;
                        case "stelem.i4":
                            valueDescript = "Replace array element at index with the int32 value on the stack.";
                            break;
                        case "stelem.i8":
                            valueDescript = "Replace array element at index with the int64 value on the stack.";
                            break;
                        case "stelem.r4":
                            valueDescript = "Replace array element at index with the i value on the stack.";
                            break;
                        case "stelem.r8":
                            valueDescript = "Replace array element at index with the float64 value on the stack.";
                            break;
                        case "stelem.ref":
                            valueDescript = "Replace array element at index with the ref value on the stack.";
                            break;
                        case "stfld":
                            valueDescript = "Replace the value of field of the object obj with value.";
                            break;
                        case "stind.i":
                            valueDescript = "Store value of type native int into memory at address";
                            break;
                        case "stind.i1":
                            valueDescript = "Store value of type int8 into memory at address";
                            break;
                        case "stind.i2":
                            valueDescript = "Store value of type int16 into memory at address";
                            break;
                        case "stind.i4":
                            valueDescript = "Store value of type int32 into memory at address";
                            break;
                        case "stind.i8":
                            valueDescript = "Store value of type int64 into memory at address";
                            break;
                        case "stind.r4":
                            valueDescript = "Store value of type float32 into memory at address";
                            break;
                        case "stind.r8":
                            valueDescript = "Store value of type float64 into memory at address";
                            break;
                        case "stind.ref":
                            valueDescript = "Store value of type object ref (type O) into memory at address";
                            break;
                        case "stloc":
                            valueDescript = "Pop a value from stack into local variable indx.";
                            break;
                        case "stloc.0":
                            valueDescript = "Pop a value from stack into local variable 0.";
                            break;
                        case "stloc.1":
                            valueDescript = "Pop a value from stack into local variable 1.";
                            break;
                        case "stloc.2":
                            valueDescript = "Pop a value from stack into local variable 2.";
                            break;
                        case "stloc.3":
                            valueDescript = "Pop a value from stack into local variable 3.";
                            break;
                        case "stloc.s":
                            valueDescript = "Pop a value from stack into local variable indx, short form.";
                            break; 
                        case "stobj":
                            valueDescript = "Store a value of type typeTok at an address.";
                            break;
                        case "stsfld":
                            valueDescript = "Replace the value of the static field with val.";
                            break;
                        case "sub":
                            valueDescript = "Subtract value2 from value1, returning a new value.";
                            break;
                        case "sub.ovf":
                            valueDescript = "Subtract native int from a native int. Signed result shall fit in same size";
                            break;
                        case "sub.ovf.un":
                            valueDescript = "Subtract native unsigned int from a native unsigned int. Unsigned result shall fit in same size.";
                            break;
                        case "switch":
                            valueDescript = "Jump to one of n values.";
                            break;
                        case "tail.":
                            valueDescript = "Subsequent call terminates current method";
                            break;
                        case "throw":
                            valueDescript = "Throw an exception.";
                            break;
                        case "unaligned.":
                            valueDescript = "Subsequent pointer instruction might be unaligned.";
                            break;
                        case "unbox":
                            valueDescript = "Extract a value-type from obj, its boxed representation.";
                            break;
                        case "unbox.any":
                            valueDescript = "Extract a value-type from obj, its boxed representation";
                            break;
                        case "volatile.":
                            valueDescript = "Subsequent pointer reference is volatile.";
                            break;
                        case "xor":
                            valueDescript = "Bitwise XOR of integer values, returns an integer.";
                            break;
                }

                 return valueDescript;
            }

        private void exportBothButton_Click(object sender, EventArgs e)
        {

            if (outputRichTextBox.Text != String.Empty)
            {
                TextWriter writer = new StreamWriter(@"C:\\Users\\magic\\Desktop\\Repeat Project\\both.txt");

                for (int n = 0; n < richTextBox1.Lines.Length; ++n)
                {
                    writer.WriteLine(richTextBox1.Lines[n]);
                }

                for (int n = 0; n < outputRichTextBox.Lines.Length; ++n)
                {
                    writer.WriteLine(outputRichTextBox.Lines[n]);
                }

                writer.Close();
            }
            else
            {
                MessageBox.Show("Output Textbox is Empty!!", "Error", MessageBoxButtons.OK);
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            TextWriter writer = new StreamWriter(@"C:\\Users\\magic\\Desktop\\Repeat Project\\.txt");

            for (int n = 0; n < outputRichTextBox.Lines.Length; ++n)
            {
                writer.WriteLine(outputRichTextBox.Lines[n]);
            }
            
            writer.Close();
        }
    }
}

