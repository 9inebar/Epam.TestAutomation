using System.Drawing;
using System.Drawing.Imaging;
using Epam.TestAutomation.Core.Helper;
using OpenQA.Selenium;

namespace Epam.TestAutomation.Core.ScreenShot;

    internal static class ScreenshotTaker
    {
        internal static void TakeScreenshot(IWebDriver driver, string testName, string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string screenFileName =
                $"{testName} {DateTime.Now:dd,MM}.{ImageFormat.Jpeg.ToString().ToLowerInvariant()}";

            string screenPath = Path.Combine(TestSettings.ScreenShotPath, screenFileName);

            using (Image screenshot = Image.FromStream(new MemoryStream(((ITakesScreenshot)driver).GetScreenshot().AsByteArray)))
            {
                screenshot.Save(screenPath);
            }
        }
    }
