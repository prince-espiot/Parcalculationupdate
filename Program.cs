/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/20/2021
 * Time: 13:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
 

namespace Parcalculationupdate
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			List<Complex> inputIQ = new List<Complex>();
			
			Console.WriteLine("Please enter an I");
			Double inter = Convert.ToDouble( Console.ReadLine());
			
			Console.WriteLine("Please enter an Q");
			Double quad = Convert.ToDouble( Console.ReadLine());
			
			Complex com = new Complex(inter, quad);
			
			//Console.WriteLine(com); //checkpoint
			
			inputIQ.Add(Complex.Abs(com));
			//Console.WriteLine(inputIQ); // checkpoint
			
			Console.WriteLine("Power in dm : "+ ParCalculation(inputIQ) );
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
	static double ParCalculation (List<Complex> inputIQ)
		{
			List<Double> Pdms = new List<Double>();
			double Pdm=0;
			const double ten = 10.000;
			int i;
			for ( i =0;i<inputIQ.Count;i++){
				Console.WriteLine("Magnitude : "+ Complex.Abs(inputIQ[i]));
				Double Vpeak = Complex.Abs(inputIQ[i]);
				Double Vpeak_dm = Math.Pow(Vpeak,2);
				Pdm = ( ten * Math.Log(10*Vpeak_dm));
				//Console.WriteLine("Power check : "+ Pdm);  // checkpoint
			}
			
			//Console.WriteLine("Power check : "+ Pdms); // checkpoint
			return Pdm;
			
			
		}
	}
	 
}