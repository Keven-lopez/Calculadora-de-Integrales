using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MaximaSharp;

namespace Custom
{
    public static class CustomCommands
    {
        public static string ToGnuplotString(this LambdaExpression expr)
        {
            string integralFunction = expr.ToString(); // Get the integral expression

            // Extract the actual function part and convert it to Gnuplot format
            string gnuplotFunction = integralFunction.Substring(integralFunction.IndexOf("=>") + 2).Trim(); // Get the right side of the expression

            // Replace '^' with '**' for Gnuplot compatibility
            gnuplotFunction = gnuplotFunction.Replace("^", "**");

            // Remove unnecessary spaces and format for Gnuplot
            gnuplotFunction = gnuplotFunction.Replace(" ", ""); // Optional: Remove spaces for cleaner output

            gnuplotFunction = gnuplotFunction.ToLower(); // Optional: Convert to lowercase for cleaner output

            // Return the Gnuplot-compatible function
            return gnuplotFunction;
        }

        public static void PlotGraph(string image, LambdaExpression resul, string gnu)
        {
            Maxima.GnuPlot($@"
                set terminal pngcairo size 500, 500                     # Set the output format and size
                set output '{image}'                                # Specify the output file name
                set grid                                                # Enable gridlines
                set title 'Grafica de {resul}'                            # Set the title of the plot
                set xlabel 'x'                                          # Label for the x-axis
                set ylabel 'y'                                          # Label for the y-axis
                set xrange [-10:10]                                     # Set the range for the x-axis
                set yrange [-10:10]                                     # Set the range for the y-axis
                set style line 1 lc rgb 'blue' lw 2                     # Define line style for the plot (blue color, line width 2)
                set style line 2 lc rgb 'black' lw 3                    # Define line style for the axes (black color, line width 3)

                # Draw the x and y axes
                set arrow from -10,0 to 10,0 nohead linecolor ls 2     # Horizontal x-axis
                set arrow from 0,-50 to 0,500 nohead linecolor ls 2    # Vertical y-axis

                plot {gnu} notitle  with linespoints ls 1              # Plot the function with lines and points
            ");


        }
        }
    }
