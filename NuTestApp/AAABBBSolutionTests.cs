using SimpleTasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuTestApplication
{
    public class AAABBBSolutionTests
    {
        private AAABBBSolution solution = new AAABBBSolution();

        [Test]
        //AA>AB>BB
        [TestCase(5, 3, 2, 16)]
        [TestCase(4, 2, 1, 10)]
        [TestCase(3, 2, 0, 6)]
        [TestCase(3, 2, 1, 10)]
        [TestCase(200, 2, 1, 10)]
        
        //AA>AB=BB
        [TestCase(20, 0, 0, 2)]
        [TestCase(1, 0, 0, 2)]
        [TestCase(5, 0, 0, 2)]
        [TestCase(3, 2, 2, 14)]
        [TestCase(3, 1, 1, 8)]

        //AA>AB<BB
        [TestCase(5, 1, 3, 16)]
        [TestCase(5, 0, 2, 10)]
        [TestCase(5, 2, 3, 18)]
        [TestCase(5, 2, 4, 22)]
        [TestCase(6, 2, 4, 22)]
        [TestCase(3, 0, 3, 12)]

        //AA=AB>BB
        [TestCase(2, 2, 4, 14)]
        [TestCase(1, 1, 3, 8)]
        [TestCase(0, 0, 1, 2)]
        [TestCase(0, 0, 4, 2)]
        [TestCase(0, 0, 40, 2)]

        //AA==AB==BB
        [TestCase(3, 3, 3, 18)]
        [TestCase(2, 2, 2, 12)]
        [TestCase(1, 1, 1, 6)]
        [TestCase(0, 0, 0, 0)]

        //AA=AB<BB
        [TestCase(0, 0, 10, 2)]
        [TestCase(0, 0, 1, 2)]
        [TestCase(0, 0, 20, 2)]

        //AA<AB>BB
        [TestCase(1, 2, 1, 8)]
        [TestCase(0, 2, 0, 4)]
        [TestCase(0, 1, 0, 2)]
        [TestCase(0, 20, 0, 40)]
        [TestCase(1, 20, 1, 44)]
        [TestCase(0, 10, 0, 20)]
        [TestCase(1, 10, 0, 22)]
        [TestCase(1, 10, 2, 26)]
        [TestCase(0, 10, 2, 22)]

        //AA<AB=BB
        [TestCase(2, 3, 3, 16)]
        [TestCase(1, 2, 2, 10)]
        [TestCase(0, 2, 2, 6)]
        [TestCase(0, 1, 1, 4)]

        //AA<AB<BB
        [TestCase(1, 2, 3, 10)]
        [TestCase(1, 2, 4, 10)]
        [TestCase(0, 2, 4, 6)]
        [TestCase(0, 2, 3, 6)]

        public void testSolution(int AA, int AB, int BB, int resultStringLength)
        {
            var testString = solution.solution(AA, AB, BB);


            Assert.That(solution.CheckLine(testString), Is.True);
            Assert.That(testString.Length, Is.EqualTo(resultStringLength));
        }
    }
}
