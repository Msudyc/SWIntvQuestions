using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACMPrep
{
    public partial class Backtracking
    {
        [TestMethod]
        public void Backtracking_SolveSudokuTest1()
        {
            char[,] board = {{'.', '.', '.', '.', '.', '.' , '.', '.', '1'},
                             {'.', '.', '.', '.', '.', '5' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'7', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'9', '.', '.', '.', '.', '.' , '.', '.', '.'}};

            SolveSudoku(board);
            Assert.AreEqual('2', board[0,0]);
        }

        [TestMethod]
        public void Backtracking_SolveSudokuTest2()
        {
            char[,] board = {{'.', '.', '.', '.', '.', '.' , '.', '.', '9'},
                             {'.', '.', '.', '.', '.', '5' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '3', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'7', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'},
                             {'.', '.', '.', '.', '.', '.' , '.', '.', '.'}};

            SolveSudoku(board);
            Assert.AreEqual('1', board[0,0]);
        }
    };
}