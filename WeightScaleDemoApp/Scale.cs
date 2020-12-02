using System;
using System.Collections;
using System.Text;

namespace WeightScaleDemoApp
{
    class Scale
    {
        public void AddElementInKilogram(double weight)
        {
            elements.Add(weight);
        }

        public double TotalWeightInKilograms()
        {
            //double totalWeight = 0;
            //foreach (double item in elements)
            //{
            //    totalWeight += item;
            //}
            //return totalWeight;

            double totalWeight = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                totalWeight += (double)elements[i];
            }
            return totalWeight;
        }

        public double TotalWeightInPounds()
        {
            return TotalWeightInKilograms() * 2.205;
        }

        // Attributes
        private ArrayList elements = new ArrayList();
    }
}
