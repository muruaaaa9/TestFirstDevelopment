using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Domain.Tests
{
    public class SizeGrouper_Tests
    {
        
        [Test]
        public void Grouping_list_of_one_by_one_produces_group_of_size_one()
        {
            var measurements = new List<Measurement>()
                {
                    new Measurement(){HighValue = 10, LowValue = 5}
                };
            
            var grouper = new SizeGrouper(1);
            var groupedResults = grouper.Group(measurements);

            Assert.AreEqual(1, groupedResults.Count);
        } 
        
        [Test]
        public void Grouping_list_of_four_by_two_produces_group_of_size_two()
        {
            var measurements = new List<Measurement>()
                {
                    new Measurement(){HighValue = 10, LowValue = 5},
                    new Measurement(){HighValue = 10, LowValue = 4},
                    new Measurement(){HighValue = 10, LowValue = 3},
                    new Measurement(){HighValue = 10, LowValue = 4},
                };
            
            var grouper = new SizeGrouper(2);
            var groupedResults = grouper.Group(measurements);

            Assert.AreEqual(2, groupedResults.Count);
            Assert.IsTrue(groupedResults.All(g=>g.Count == 2));
        }
    }
} 
