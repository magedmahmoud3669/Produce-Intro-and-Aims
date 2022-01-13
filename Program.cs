  using GemBox.Document;
using HtmlAgilityPack;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SautinSoft.Document.Drawing;

namespace Title_And_Goals
{
    class Program
    {



        static void maged(string[] link, String dpath, int counti, int count, int lesson_Number)
        {
            var courses = new Dictionary<string, string>(){
                                { "1-1","الفقه الحنفي - القسم الأول"},
                                { "1-2","الفقه الشافعي - القسم الأول"},
                                { "1-3","الفقه المالكي - القسم الأول"},
                                { "1-4","أصول الفقه - القسم الأول" },
                                { "1-5","النحو"},
                                {"1-6","المنطق" },
                                {"1-7","الفتوى" },
                                {"1-8","مصطلح الحديث" },
                                {"1-9","مبادئ علم الاقتصاد" },
                                {"1-10","الصرف" },
                                {"1-11","التخريج ودراسة الأسانيد" },
                                {"1-12","التدريب علي الفتوى - القسم الأول" },

                                {"2-1","الفقه الحنفي - القسم الثالث"},
                                {"2-2","الفقه الشافعي - القسم الثالث"},
                                {"2-3","الفقه المالكي - القسم الثالث"},
                                {"2-4","أصول الفقه - القسم الثاني" },
                                {"2-5","التدريب على الفتوى - القسم الثاني"},
                                {"2-6","البلاغة" },
                                {"2-7","آيات الأحكام" },
                                {"2-8","مقاصد الشريعة العامة" },
                                {"2-9","الولاية على النفس" },
                                {"2-10","مبادئ علم الاجتماع" },
                                {"2-11","أحاديث الأحكام" },
                                {"2-12","مقاصد الشريعة في الأسرة" },

                                    {"3-1","الفقه الحنفي - القسم الثاني"},
                                {"3-2","الفقه الشافعي - القسم الثاني"},
                                {"3-3","الفقه المالكي - القسم الثاني"},
                                {"3-4","أصول الفقه - القسم الثالث" },
                                {"3-5","التدريب على الفتوى - القسم الثالث"},
                                {"3-6","الأحوال الشخصية" },
                                {"3-7","قضايا فقهية معاصرة" },
                                {"3-8","المواريث والوصية" },
                                {"3-9","علم الاجتماع العائلي" },
                                {"3-10","المنظمات وحقوق الإنسان" },
                                {"3-11","علم النفس" },



                            };
            var resi = "";
            var res = "";
            foreach (var course in courses)
            {
                res = counti + "-" + count;
                if (res == course.Key)
                {
                   resi=course.Value;
                }
                //Console.WriteLine("Key: {0}, Value: {1}", course.Key, course.Value);

            }
                 var index= @"C:\Users\20106\Desktop\data\index.html";

           
                var info = @"I:\data2\" + res + resi + ".html";




            //using (StreamWriter sw2 = File.AppendText(info))
            //{

            

        //}





        var path = dpath;

                // Console.WriteLine(path);
                var doc = new HtmlDocument();
                doc.Load(path);
            //       / html / body / div[2] / div[3] / div[1] / div / div / div / div / div[2] / div[2] / div / div / div[3] / div[2] / div[2] / div / div / div[1]
            //var node = doc.DocumentNode.SelectSingleNode("//body//div//@title");
            //var node = doc.DocumentNode.SelectNodes("//body//div//@title");
            //HtmlNode[]mokrr = doc.DocumentNode.SelectNodes("//body//div[class='mokrr']").ToArray();
            //Console.WriteLine(mokrr[0].InnerHtml);

            HtmlNode[] nodes = doc.DocumentNode.SelectNodes("//body//div[@title='الدرس']").ToArray();
                // HtmlNode[] nodes22 = doc.DocumentNode.SelectNodes("//body//div//span").ToArray();
                HtmlNode[] nodes2 = doc.DocumentNode.SelectNodes("//body//div[@class='TextArea content-rd']").ToArray();
            //HtmlNode[] nodes2 = doc.DocumentNode.SelectNodes("//body//div[2]//div[3]//div[1]//div//div//div//div//div[2]//div[2]//div//div//div[3]//div[2]//div[2]//div//div//div[1]").ToArray();
            ////body//div[2]//div[3]//div[1]//div//div//div//div//div[2]//div[2]//div//div//div[3]//div[2]//div[2]//div//div//div[1]

            using (StreamWriter sw = File.AppendText(info))
                {

                //sw.WriteLine(mokrr[0].InnerHtml);
                //Console.WriteLine(mokrr[0].InnerHtml);

                sw.WriteLine("<div style='direction: rtl; font-family: Traditional Arabic; font-size: 22px;'>");
                sw.WriteLine("<style> .عنوان-فرعي1{ Font-size:21px; Font-weight:bold;  } </style>");
               // HtmlNode[] mokrr = doc.DocumentNode.SelectNodes("//body//div[@class='mokrr']").ToArray();
                HtmlNodeCollection mokrr = doc.DocumentNode.SelectNodes("//body//div[@class='mokrr']");
                HtmlNodeCollection AIMS = doc.DocumentNode.SelectNodes("//body//div[@class='AIMS']");
                if (mokrr != null)
                {
                    sw.WriteLine(mokrr[0].InnerHtml);
                }
                if (AIMS != null)
                {
                    sw.WriteLine(AIMS[0].InnerHtml);
                }
               

                if (lesson_Number ==1)
                {
                   
               
               
                    //            HtmlNode[] mokrr = doc.DocumentNode.SelectNodes("//body//div[@class='mokrr']").ToArray();
                    //HtmlNode[] AIMS = doc.DocumentNode.SelectNodes("//body//div[@class='AIMS']").ToArray();


                    //sw.WriteLine(mokrr[0].InnerHtml);
                    //            sw.WriteLine(AIMS[0].InnerHtml);

                    sw.WriteLine(" <div class='container'><div class='accordion accordion-flush' id='accordionFlushExample'>  <div class='accordion-item'> <h2 class='accordion-header' id='flush-headingOne'>   <button class='accordion-button collapsed' type='button' data-bs-toggle='collapse' data-bs-target='#flush-collapseOne' aria-expanded='true' aria-controls='flush-collapseOne'>   جميع الدروس </button>  </h2>   <div id = 'flush-collapseOne' class='accordion-collapse collapse' aria-labelledby='flush-headingOne' data-bs-parent='#accordionFlushExample'></div></div>");

                }
                //  sw.WriteLine("<div style='Font-size:21px; Font-weight:bold;'>" + "الدرس رقم:" + lesson_Number + "</div>");
                            
                sw.WriteLine("<div class='accordion' id='accordionExample'> <div class='accordion-item'> <h2 class='accordion-header' id='headingOne'>  <button class='accordion-button' type='button' data-bs-toggle='collapse' data-bs-target='#collapse"+ lesson_Number + "' aria-expanded='true' aria-controls='collapse" + lesson_Number + "'>  <div style = 'Font-size:21px; Font-weight:bold;' > " + "الدرس رقم: " + lesson_Number + "<br>"+ (nodes[0].InnerHtml) + "</div></button></h2>");
               // sw.WriteLine(nodes[0].InnerHtml);

                int size = nodes2.Length;

                //  sw.WriteLine(nodes2[5].InnerText);
                ////test
                ///


                if (File.Exists(info))
                {
                    Console.WriteLine("Specified file exists.");
                }
                else
                {
                    using (StreamWriter swrite = File.AppendText(index))
                    {

                        swrite.WriteLine("<div> ");
                        swrite.WriteLine("<a href='" + info + "'>" + info + "</a>");
                        swrite.WriteLine("</div> ");
                    }
                }

                foreach (HtmlNode item in nodes2)
                    {

                    var introBody = item.InnerHtml;
                    introBody = introBody.Replace("والآن عزيزي الدارس اضغط على زر «التالي» لبدء المحاضرة:", "");
                    introBody = introBody.Replace("<hr align=\"center\" class=\"line\">", "");
                    introBody = introBody.Replace("align=\"center\"", "");


                    //  sw.WriteLine(introBody);
                    sw.WriteLine("<div id= 'collapse" + lesson_Number + "' class='accordion-collapse collapse' aria-labelledby='headingOne' data-bs-parent='#accordionExample'><div class='accordion-body'>");
                    sw.WriteLine(introBody);
                     
                }


                sw.WriteLine("<div style='Font-size:21px; Font-weight:bold;'>" + "العناصر:" + "</div>");
                sw.WriteLine("<div style='Font-size:21px; '><ol>");

                foreach (var item in link)
                    {
                        var patharray = item;

                        doc.Load(patharray);
                        if (doc.DocumentNode.SelectNodes("//body//div[@class='TextArea content-rd']//p//a[@class='عناصر']") != null)
                        {
                            HtmlNode[] nodes3 = doc.DocumentNode.SelectNodes("//body//div[@class='TextArea content-rd']//p//a[@class='عناصر']").ToArray();


                            foreach (var item2 in nodes3)
                            {

                            sw.WriteLine("<li>");
                            sw.WriteLine(item2.InnerHtml);
                            //Console.WriteLine(item2.InnerText);
                            sw.WriteLine("</li>");

                        }

                        }
                    }

                sw.WriteLine("</ol></div>");

                sw.WriteLine("</div></div></div></div>");

               
            }
           // sw.WriteLine("<a id = 'back-to-top' href = '#' class='btn btn-light btn-lg back-to-top' role='button' style='position: fixed; bottom: 35px; right:25px;'><i class='fas fa-chevron-up'></i></a>");

        }
        static int directcounter(string x)
            {
                int counter = System.IO.Directory.GetDirectories(x).Length;
                return counter;
            }
            static void printing(string[] link, string info, int i, int y, int z)
            {

                maged(link, info, i, y, z);
            }


            static void Main(string[] args)
            {

                // ;
                int directoryCount = directcounter(@"D:\courses\");

                for (int i = 1; i <= directoryCount; i++)
                {
                    int fdirectoryCount = directcounter(@"D:\courses\" + i);
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("beginning of class {0} ", i);
                    Console.WriteLine("---------------------------");
                    for (int y = 1; y <= fdirectoryCount; y++)
                    {



                        if (y > 9)
                        {
                            Console.WriteLine("----------");
                            Console.WriteLine(" lesson {0} ", y);
                            Console.WriteLine("----------");

                            int counter = directcounter(@"D:\courses\" + i + @"\0" + i + "-" + y);

                            for (int z = 1; z <= counter; z++)
                            {
                                //.OrderByDescending(f => f).
                                var dirss = Directory.GetFiles(@"D:\courses\" + i + @"\0" + i + "-" + y + @"\" + z).OrderBy(f => f).ToArray();
                                Console.WriteLine("number of Html Files {0}.", dirss.Length);
                                //foreach (var item in dirss)
                                //{
                                //    Console.WriteLine(item);
                                //}

                                int sizer = dirss.Length - 3;
                                Console.WriteLine("herer" + dirss[2]);
                                
                                printing(dirss, dirss[0], i, y, z);
                            }

                        }


                   
                    else
                        {
                            int sdirectoryCount = System.IO.Directory.GetDirectories(@"D:\courses\" + i + @"\0" + i + "-0" + y).Length;
                            Console.WriteLine("----------");
                            Console.WriteLine(" lesson {0} ", y);
                            Console.WriteLine("----------");

                            int counter = directcounter(@"D:\courses\" + i + @"\0" + i + "-0" + y);
                            for (int z = 1; z <= counter; z++)
                            {





                                string[] dirss = Directory.GetFiles(@"D:\courses\" + i + @"\0" + i + "-0" + y + @"\" + z);

                                foreach (var item in dirss)
                                {
                                    // foreach (var course in courses)
                                    //Console.WriteLine("Key: {0}, Value: {1}", course.Key, course.Value);

                                     Console.WriteLine(item);

                                }
                            if (i==1 && (y==7 ||y==9 ))
                            {
                                printing(dirss, dirss[0], i, y, z);
                            }


                                if (i == 2 || i == 3)
                                {
                                    printing(dirss, dirss[0], i, y, z);
                                }

                                if (i == 1 && y!=7 && y!=9 )
                                {
                                    printing(dirss, dirss[1], i, y, z);
                                }


                            }

                        }

                    }
                    string[] dirs = Directory.GetFiles(@"D:\courses\1\01-01\1");
                    //Console.WriteLine(directoryCount+"***"+dirs.Length);
                }
            }
        }
    
}
