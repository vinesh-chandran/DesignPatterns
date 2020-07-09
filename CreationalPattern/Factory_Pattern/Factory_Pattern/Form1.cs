using Factory_Pattern.WithInterface;
using Factory_Pattern.WithoutInterface;
using System;
using System.Windows.Forms;

namespace Factory_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // This issue can be solved using Factory Method..
            ProblemSolved objProb = new ProblemSolved(12, 1, 1);

            // Method 1 without interface..
            var point1 = PointProgram.NewCartesianPoint(1.0, Math.PI / 2);
            var point2 = PointProgram.NewPolarsPoint(2, 3);
            /////////////////////////////

            // Method 2 with interface.. Creator class(This calls the factory)..
            PointFactory ptFact = new PointFactory();
            var objPoint1 = ptFact.CreateFactory(1);
            objPoint1.Draw(1.0, Math.PI / 2);

            var objPoint2 = ptFact.CreateFactory(2);
            objPoint2.Draw(2, 3);
            /////////////////////////////
        }
    }
}
