using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Web;

namespace MeHasVisto.Models.Bussines
{
    public class PetManagement
    {
        public static void CreateThumbNail(
            string fileName, string filePath, int thumbWi, int thumbHi,
            bool maintainAspect)
        {
            //No hacer nada si el tamaño
            //original es mas pequeño que
            //el desigmado para la
            //vista previa (thumbnail)
            var originalFile = Path.Combine(filePath,
                fileName);
            var source = Image.FromFile(originalFile);
            if (source.Width <= thumbWi &&
                source.Height <= thumbHi)
                return;

            Bitmap thumbnail;
            try
            {
                int Wi = thumbWi;
                int hi = thumbHi;
                if (maintainAspect)
                {
                    Wi = thumbWi;
                    hi = (int)(source.Height *
                        ((decimal)thumbWi / source.Width));
                }

                else
                {
                    hi = thumbHi;
                    Wi = (int)(source.Width *
                        ((decimal)thumbHi / source.Height));
                }
                thumbnail = new Bitmap(Wi, hi);
                using (Graphics g = Graphics.FromImage(thumbnail)) 
                {
                    g.InterpolationMode =
                        InterpolationMode.HighQualityBicubic;
                    g.FillRectangle(Brushes.Transparent,
                        0, 0,
                        Wi, hi);
                    g.DrawImage(source, 0, 0, Wi, hi);

                    var thumbnailName = Path.Combine(filePath,
                        "thumbnail_" + fileName);
                    thumbnail.Save(thumbnailName);
                }
            }
            catch
            {
            }

                }
            }
        }