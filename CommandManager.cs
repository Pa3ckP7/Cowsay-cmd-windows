using System;
using System.Collections.Generic;
using System.Text;

namespace Cowsay_cmd
{
    class CommandManager
    {
        public void Sprejem(String[] args)
        {
            if (args[0].Equals("?"))
            {
                Console.WriteLine("This is a recreation of cowsay command from linux.\n" +
                    "The message should always be surrounded  by double quotes\n" +
                    "After the message you have the following switches to set custom eyes\n" +
                    "-b | borg eyes\n" +
                    "-d | dead\n" +
                    "-g | gready\n" +
                    "-p | paranoid\n" +
                    "-s | stoned\n" +
                    "-t | sleapy\n" +
                    "-w | wired\n" +
                    "-y | youth\n" +
                    "-e | folow it with a simbol you want for eyes");
            }
            else
            {
                
                String msg;
                String eye;
                switch (args.Length)
                {
                    case 1:
                        msg = args[0];
                        Output(msg);
                        break;
                    case 2:
                        for (int i = 0; i < args.Length; i++)
                        {
                            args[i] = args[i].Replace("-", "");
                        }
                        msg = args[0];
                        eye = args[1];
                        switch (eye)
                        {
                            case "b":
                                eye = "=";
                                break;
                            case "d":
                                eye = "x";
                                break;
                            case "g":
                                eye = "$";
                                break;
                            case "p":
                                eye = "@";
                                break;
                            case "s":
                                eye = "*";
                                break;
                            case "t":
                                eye = "-";
                                break;
                            case "w":
                                eye = "O";
                                break;
                            case "y":
                                eye = ".";
                                break;
                            default:
                                break;
                        }
                        Output(msg, eye);
                        break;
                    case 3:
                        Output(args[0], args[2]);
                        break;
                }

            }


        }
        void Output(String msg, String eye = "o")
        {
            Console.Write(" ");
            for (int i = 0; i < (msg.Length + 2); i++)
            {
                Console.Write($"_");
            }
            Console.WriteLine($"\n< {msg} >");
            Console.Write(" ");
            for (int i = 0; i < (msg.Length + 2); i++)
            {
                Console.Write($"-");
            }
            Console.WriteLine($"\n        \\   ^__ ^" +
                $"\n         \\  ({eye}{eye})\\_______\n            (__)\\       )\\/\\" +
                $"\n                || ----w |\n                ||     || ");
        }
    }
}
