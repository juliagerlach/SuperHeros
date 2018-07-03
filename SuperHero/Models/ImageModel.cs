using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace SuperHero.Models
{
    public class ImageModel:List<Image>
    {
public ImageModel()
        {
            string directoryOfImage = HttpContext.Current.Server.MapPath("~/Images/");
            XDocument imageData = XDocument.Load(directoryOfImage + @"/ImageMetaDAta.xml");
            var images = from image in imageData.Descendants("image") select new Image(image.Element("poison-ivy-on-a-bed-of-plants.jpg").Value, image.Element("Poison Ivy").Value);
            this.AddRange(images.ToList<Image>());
        }
    }
}