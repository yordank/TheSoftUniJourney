using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Homework;
using Homework.Problems;

namespace HomeworkUnitTest
{
    [TestClass]
    public class UnitTestHomework
    {
        [TestMethod]
        public void Progblem8UnitTest()
        {

            string[,] arr = new string[,]
           {
                { "0","0","0" ,"0","0","x"},
                { "0","x","x" ,"x","0","x"},
                { "0","x","*" ,"x","0","x"},
                { "0","x","0" ,"x","0","x"},
                { "0","x","0" ,"x","0","x"},
                { "0","0","0" ,"x","0","0"}

           };

            var p = new Homework.Problems.Problem8();

            var result=p.solution(arr);

            string[,] expected = new string[,]
             {
                { "10","11","12" ,"13","14","x"},
                { "9","x","x" ,"x","15","x"},
                { "8","x","*" ,"x","16","x"},
                { "7","x","1" ,"x","17","x"},
                { "6","x","2" ,"x","18","x"},
                { "5","4","3" ,"x","19","20"}

             };

            CollectionAssert.AreEqual(result, expected);
        }
    }
}
