﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLefRotation;
using FluentAssertions;
using Xunit;

namespace ArrayLefRotation_Tests
{
    
    public class Main_Tests
    {
        #region ShiftLeft

        //should be given a 1 with rotate 2 and it will return '1':
        [Fact]
        public void ShiftLeft_ShouldShiftOne()
        {
            int[] testSeq = Enumerable.Range(1, 1).ToArray();
            int shiftPos = 2;
            int[] expectedOutput = new[] { 1 };

            int[] output = Program.ShiftLeft(testSeq, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        //should be given a 2 with a rotation of 1 and it will return '2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftOneWithTwoElements()
        {
            int[] testSeq = Enumerable.Range(1, 2).ToArray();
            int shiftPos = 1;
            int[] expectedOutput = { 2, 1 };

            int[] output = Program.ShiftLeft(testSeq, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        //should be given a 2 with a rotation of 2 and it will return '1 2':
        [Fact]
        public void ShiftLeft_ShouldShiftTwoWithTwoElements()
        {
            int[] testSeq = Enumerable.Range(1, 2).ToArray();
            int shiftPos = 2;
            int[] expectedOutput = new[] { 1, 2 };

            int[] output = Program.ShiftLeft(testSeq, shiftPos);

            output.Should().Equal(expectedOutput);
        }


        //should be given a 3 with a rotation of 2 and it will return '3 2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftTwo()
        {
            
            int[] testSeq = Enumerable.Range(1, 3).ToArray();
            int shiftPos = 2;
            int[] expectedOutput = new[] { 3, 1, 2 };

            int[] output = Program.ShiftLeft(testSeq, shiftPos);

            output.Should().Equal(expectedOutput);
        }


        //should be given a 3 with a rotation of 2 and it will return '3 2 1':
        [Fact]
        public void ShiftLeft_ShouldShiftFour()
        {
            int[] testSeq = Enumerable.Range(1, 5).ToArray();
            int shiftPos = 4;
            int[] expectedOutput = { 5, 1, 2, 3, 4 };

            int[] output = Program.ShiftLeft(testSeq, shiftPos);

            output.Should().Equal(expectedOutput);
        }

        #endregion

        #region GetShiftedIndex
        [Theory]
        [InlineDataAttribute(5, 1, 4, 3)]
        [InlineDataAttribute(5, 1, 0, 4)]
        [InlineDataAttribute(5, 1, 3, 2)]
        [InlineDataAttribute(5, 2, 0, 3)]
        public void GetShiftedIndex(int arrayLength, int shiftNumber, int originalIndex, int expectedIndex)
        {
            int output = Program.GetShiftedIndex(arrayLength, shiftNumber, originalIndex);

            output.Should().Be(expectedIndex);
        }
        #endregion


        #region ShiftArray

        [Theory]
        [InlineDataAttribute("5 4", "1 2 3 4 5", "5 1 2 3 4")]
        [InlineDataAttribute("20 10", "41 73 89 7 10 1 59 58 84 77 77 97 58 1 86 58 26 10 86 51", "77 97 58 1 86 58 26 10 86 51 41 73 89 7 10 1 59 58 84 77")]
        [InlineDataAttribute("15 13", "33 47 70 37 8 53 13 93 71 72 51 100 60 87 97", "87 97 33 47 70 37 8 53 13 93 71 72 51 100 60")]
        public void ShiftArray_ReturnsCorrectShiftedArray(string probDesc, string inputSeq, string expectedOutput)
        {
            string output = Program.GetShiftedArray(probDesc, inputSeq);

            output.Should().Be(expectedOutput);
        }
        #endregion


    }
}
