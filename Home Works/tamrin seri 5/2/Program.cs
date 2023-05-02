using System;

namespace _2
{
    class sudoku
    {
        public int[,] sud = new int[9 , 9] {{5,3,0,0,7,0,0,0,0} , {6,0,0,1,9,5,0,0,0} , {0,9,8,0,0,0,0,6,0} , {8,0,0,0,6,0,0,0,3} , {4,0,0,8,0,3,0,0,1} , {7,0,0,0,2,0,0,0,6} , {0,6,0,0,0,0,2,8,0} , {0,0,0,4,1,9,0,0,5} , {0,0,0,0,8,0,0,7,9}};
        
        public void add ()
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            if(i>=0 && j>=0 && number>0 && number<10 && i<9 && j<9)
            {
                if((i!=0 && j!=0) && (i!=0 && j!=1) && (i!=0 && j!=4) && (i!=1 && j!=0) && (i!=1 && j!=3) && (i!=1 && j!=4) && (i!=1 && j!=5) && (i!=2 && j!=1) && (i!=2 && j!=2) && (i!=2 && j!=7) && (i!=3 && j!=0) && (i!=3 && j!=4) && (i!=3 && j!=8) && (i!=4 && j!=0) && (i!=4 && j!=3) && (i!=4 && j!=5) && (i!=4 && j!=8) && (i!=5 && j!=0) && (i!=5 && j!=4) && (i!=5 && j!=8) && (i!=6 && j!=1) && (i!=6 && j!=6) && (i!=6 && j!=7) && (i!=7 && j!=3) && (i!=7 && j!=4) && (i!=7 && j!=5) && (i!=7 && j!=8) && (i!=8 && j!=4) && (i!=8 && j!=7) && (i!=8 && j!=8))
                {
                    if(number != sud[i,0] && number != sud[i,1] && number != sud[i,2] && number != sud[i,3] && number != sud[i,4] && number != sud[i,5] && number != sud[i,6] && number != sud[i,7] && number != sud[i,8] && number != sud[0,j] && number != sud[1,j] && number != sud[2,j] && number != sud[3,j] && number != sud[4,j] && number != sud[5,j] && number != sud[6,j] && number != sud[7,j] && number != sud[8,j])
                    {
                        if(sud[i,j] == 0)
                        {
                            int mohem1 = 0;
                            if (i >= 0 && i <= 2 && j >= 0 && j <= 2)
                            {
                                for (int w = 0 , p = 0; w <= 2 && p <= 2; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem1 = 1;
                                    }
                                }
                                if (mohem1 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem2 = 0;
                            if (i >= 0 && i <= 2 && j >= 3 && j <= 5 )
                            {
                                for (int w = 0 , p = 3; w <= 2 && p <= 5; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem2 = 1;
                                    }
                                }
                                if (mohem2 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem3 = 0;
                            if (i <= 2 && j >= 6 && j <= 8)
                            {
                                for (int w = 0 , p = 6; w <= 2 && p <= 8; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem3 = 1;
                                    }
                                }
                                if (mohem3 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem4 = 0;
                            if (i >= 3 && i <= 5 && j >= 0 && j <= 2)
                            {
                                for (int w = 3 , p = 0; w <= 5 && p <= 2; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem4 = 1;
                                    }
                                }
                                if (mohem4 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem5 = 0;
                            if (i >= 3 && i <= 5 && j >= 3 && j <= 5 )
                            {
                                for (int w = 3 , p = 3; w <= 5 && p <= 5; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem5 = 1;
                                    }
                                }
                                if (mohem5 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem6 = 0;
                            if (i >= 3 && i <= 5 && j >= 6 && j <= 8)
                            {
                                for (int w = 3 , p = 6; w <= 5 && p <= 8; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem6 = 1;
                                    }
                                }
                                if (mohem6 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem7 = 0;
                            if (i >= 6 && i <= 8 && j >= 0 && j <= 2)
                            {
                                for (int w = 6 , p = 0; w <= 8 && p <= 2; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem7 = 1;
                                    }
                                }
                                if (mohem7 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem8 = 0;
                            if (i >= 6 && i <= 8 && j >= 3 && j <= 5)
                            {
                                for (int w = 6 , p = 3; w <= 8 && p <= 5; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem8 = 1;
                                    }
                                }
                                if (mohem8 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                            int mohem9 = 0;
                            if (i >= 6 && i <= 8 && j >= 6 && j <= 8)
                            {
                                for (int w = 6 , p = 6; w <= 8 && p <= 8; w++ , p++)
                                {
                                    if(sud[i,j] == sud[w,p])
                                    {
                                        Console.WriteLine("vorudi eshtebah ast");
                                        mohem9 = 1;
                                    }
                                }
                                if (mohem9 == 0)
                                {
                                    sud[i,j] = number;
                                }
                            }

                        }
                    }
                }
            } 
        }

        public void del ()
        {
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            if(i >= 0 && j >= 0 && i <= 8 && j <= 8)
            {
                if((i!=0 && j!=0) && (i!=0 && j!=1) && (i!=0 && j!=4) && (i!=1 && j!=0) && (i!=1 && j!=3) && (i!=1 && j!=4) && (i!=1 && j!=5) && (i!=2 && j!=1) && (i!=2 && j!=2) && (i!=2 && j!=7) && (i!=3 && j!=0) && (i!=3 && j!=4) && (i!=3 && j!=8) && (i!=4 && j!=0) && (i!=4 && j!=3) && (i!=4 && j!=5) && (i!=4 && j!=8) && (i!=5 && j!=0) && (i!=5 && j!=4) && (i!=5 && j!=8) && (i!=6 && j!=1) && (i!=6 && j!=6) && (i!=6 && j!=7) && (i!=7 && j!=3) && (i!=7 && j!=4) && (i!=7 && j!=5) && (i!=7 && j!=8) && (i!=8 && j!=4) && (i!=8 && j!=7) && (i!=8 && j!=8))
                {
                    if(sud[i,j] != 0)
                    {
                        sud[i,j] = 0;
                    }
                }
            }
        }

        public void ShowChart ()
        {
            for (int i = 0 , j = 0; i < 9 ; i++)
            {
                Console.WriteLine(sud[i,j] + " " + sud[i,j+1] + " " + sud[i,j+2] + " " + sud[i,j+3] + " " + sud[i,j+4] + " " + sud[i,j+5] + " " + sud[i,j+6] + " " + sud[i,j+7] + " " + sud[i,j+8]);
                j = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("shomare mored nazar khod ra vared konid");
            Console.WriteLine("1 == Add");
            Console.WriteLine("2 == Del");
            Console.WriteLine("3 == ShowChart");
            Console.WriteLine("4 == khoruj");
            sudoku c = new sudoku();
            int vorudi = 0;
            for( ;vorudi != 4; )
            {
                vorudi = int.Parse(Console.ReadLine());
                if(vorudi == 1)
                {
                    c.add();
                }
                if (vorudi == 2)
                {
                    c.del();
                }
                if (vorudi == 3)
                {
                    c.ShowChart();
                }
            }
        }
    }
}
