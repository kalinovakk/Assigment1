using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigmenttt
{
    class Student: Person
    {
        public Student(string firstName, string lastName, 
            int age,
            string studentNumber,
            Address address,
            List<int> scores) : base(firstName, lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.studentNumber = studentNumber;
            this.address = address;
            this.scores = scores;
        }

        public string studentNumber { get; set; }
        public int age { get; set; }
        public Address address { get; set; }

        public string FullName()
        {
            return this.firstName + " " + this.lastName;
        }

        public List<int> scores { get; set; }

        public double AverageScore()
        {
            int count = this.scores.Count;
            int sum = 0;
            foreach (var score in this.scores)
            {
                sum += score;
            }
            return sum / count;
        }

        public string FullAddress()
        {
            return "Address:" + this.address.country + " " + this.address.city + " " + this.address.street;
        }

        public override string ToString()
        {
            string scoresStr = "";
            foreach (var score in this.scores)
            {
                scoresStr += score + " ";
            }
            string studentOutput = $"Student: {this.firstName} {this.lastName}. \n" +
                                   $"Age: {this.age}. Address: {this.address.country} {this.address.city} {this.address.street} \n" + 
                                   $"Scores: {scoresStr}";
            return studentOutput;
        }
    }
}
