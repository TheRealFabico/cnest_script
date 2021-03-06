/* VERSION 1.4 */

namespace CNest
{
    /** <summary>CNest Initializer</summary> **/
    public class Init
    {
        /** <summary>Creates a CNest Control</summary> **/
        public Init _(System.Windows.Forms.Control control)
        {
            ExtControl = control;

            return this;
        }

        private System.Windows.Forms.Control ExtControl;

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
            private static extern System.IntPtr CreateRoundRectRgn
            (
                int nLeftRect,     // x-coordinate of upper-left corner
                int nTopRect,      // y-coordinate of upper-left corner
                int nRightRect,    // x-coordinate of lower-right corner
                int nBottomRect,   // y-coordinate of lower-right corner
                int nWidthEllipse, // width of ellipse
                int nHeightEllipse // height of ellipse
            );

        /** <summary>Adds a border radius to every CNest control</summary> **/
        public Init Radius(int x = 20, int y = -1)
        {
            if(y == -1)
            {
                y = x;
            }

            ExtControl.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, ExtControl.Width, ExtControl.Height, x, y));
            
            return this;
        }

        /** <summary>Moves the given CNest control to x & y</summary> **/
        public Init Move(int x, int y)
        {
            ExtControl.Location = new System.Drawing.Point(x, y);
            
            return this;
        }

        /** <summary>Returns the position of the given CNest control</summary> **/
        public System.Drawing.Point Position()
        {
            return ExtControl.Location;
        }

        /** <summary>Moves the given CNest control to position x</summary> **/
        public Init MoveX(int x)
        {
            ExtControl.Location = new System.Drawing.Point(x, ExtControl.Location.Y);

            return this;
        }

        /** <summary>Return the position x of the given CNest control</summary> **/
        public int PositionX()
        {
            return ExtControl.Location.X;
        }

        /** <summary>Moves the given CNest control to position y</summary> **/
        public Init MoveY(int y)
        {
            ExtControl.Location = new System.Drawing.Point(ExtControl.Location.X, y);

            return this;
        }

        /** <summary>Return the position x of the given CNest control</summary> **/
        public int PositionY()
        {
            return ExtControl.Location.Y;
        }

        /** <summary>Returns the left position of the given CNest control</summary> **/
        public int Left()
        {
            return ExtControl.Location.X;
        }

        /** <summary>Returns the top position of the given CNest control</summary> **/
        public int Top()
        {
            return ExtControl.Location.Y;
        }

        /** <summary>Returns the right position of the given CNest control</summary> **/
        public int Right()
        {
            return ExtControl.Location.X + ExtControl.Width;
        }

        /** <summary>Returns the bottom position of the given CNest control</summary> **/
        public int Bottom()
        {
            return ExtControl.Location.Y + ExtControl.Height;
        }

        /** <summary>Changes the width of the given CNest control</summary> **/
        public Init Width(int width)
        {
            ExtControl.Width = width;
            
            return this;
        }

        /** <summary>Returns the width of the given CNest control</summary> **/
        public int Width()
        {
            return ExtControl.Width;
        }

        /** <summary>Returns the width including margin of the given CNest control</summary> **/
        public int OuterWidth()
        {
            return ExtControl.Width + ExtControl.Margin.Left + ExtControl.Margin.Right;
        }

        /** <summary>Returns the width without padding of the given CNest control</summary> **/
        public int InnerWidth()
        {
            return ExtControl.Width - (ExtControl.Padding.Left + ExtControl.Padding.Right);
        }

        /** <summary>Changes the height of the given CNest control</summary> **/
        public Init Height(int height)
        {
            ExtControl.Height = height;
            
            return this;
        }

        /** <summary>Returns the height of the given CNest control</summary> **/
        public int Height()
        {
            return ExtControl.Height;
        }

        /** <summary>Returns the height including margin of the given CNest control</summary> **/
        public int OuterHeight()
        {
            return ExtControl.Width + ExtControl.Margin.Top + ExtControl.Margin.Bottom;
        }

        /** <summary>Returns the height without padding of the given CNest control</summary> **/
        public int InnerHeight()
        {
            return ExtControl.Width - (ExtControl.Padding.Top + ExtControl.Padding.Bottom);
        }

        /** <summary>Sets the background color in RGB of the given CNest control</summary> **/
        public Init BGColor(int r, int g, int b)
        {
            ExtControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(r)))), ((int)(((byte)(g)))), ((int)(((byte)(b)))));

            return this;
        }

        /** <summary>Sets the background color in Hex of the given CNest control</summary> **/
        public Init BGColor(string hex)
        {
            if (hex.IndexOf('#') != -1)
                hex = hex.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);

            ExtControl.BackColor = System.Drawing.Color.FromArgb(r, g, b);

            return this;
        }

        /** <summary>Sets the background color of the given CNest control</summary> **/
        public Init BGColor(System.Drawing.Color color)
        {
            ExtControl.BackColor = color;

            return this;
        }

        /** <summary>Returns the background color of the given CNest control</summary> **/
        public System.Drawing.Color BGColor()
        {
            return ExtControl.BackColor;
        }

        /** <summary>Sets the foreground color in RGB of the given CNest control</summary> **/
        public Init FGColor(int r, int g, int b)
        {
            ExtControl.ForeColor = System.Drawing.Color.FromArgb(r, g, b);

            return this;
        }

        /** <summary>Sets the foreground color in Hex of the given CNest control</summary> **/
        public Init FGColor(string hex)
        {
            if (hex.IndexOf('#') != -1)
                hex = hex.Replace("#", "");

            int r, g, b = 0;

            r = int.Parse(hex.Substring(0, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            g = int.Parse(hex.Substring(2, 2), System.Globalization.NumberStyles.AllowHexSpecifier);
            b = int.Parse(hex.Substring(4, 2), System.Globalization.NumberStyles.AllowHexSpecifier);

            ExtControl.ForeColor = System.Drawing.Color.FromArgb(r, g, b);

            return this;
        }

        /** <summary>Sets the foreground color of the given CNest control</summary> **/
        public Init FGColor(System.Drawing.Color color)
        {
            ExtControl.ForeColor = color;

            return this;
        }

        /** <summary>Returns the foreground color of the given CNest control</summary> **/
        public System.Drawing.Color FGColor()
        {
            return ExtControl.ForeColor;
        }

        /** <summary>Changes the text of the given CNest control</summary> **/
        public Init Text(string text)
        {
            ExtControl.Text = text;

            return this;
        }

        /** <summary>Returns the text of the given CNest control</summary> **/
        public string Text()
        {
            return ExtControl.Text;
        }

        /** <summary>Changes the visibility state of the given CNest control</summary> **/
        public Init Visible(bool toggle)
        {
            ExtControl.Visible = toggle;

            return this;
        }

        /** <summary>Returns the visibility state of the given CNest control</summary> **/
        public bool Visible()
        {
            return ExtControl.Visible;
        }

        /** <summary>Changes the enable state of the given CNest control</summary> **/
        public Init Enabled(bool toggle)
        {
            ExtControl.Enabled = toggle;

            return this;
        }

        /** <summary>Returns the enable state of the given CNest control</summary> **/
        public bool Enabled()
        {
            return ExtControl.Enabled;
        }

        /** <summary>Sets a Background Image of the given CNest control</summary> **/
        public Init Img(System.Drawing.Image img)
        {
            ExtControl.BackgroundImage = img;

            return this;
        }

        /** <summary>Returns the Background Image of the given CNest control</summary> **/
        public System.Drawing.Image Img()
        {
            return ExtControl.BackgroundImage;
        }

        /** <summary>Adds events to the given CNest control ("Click", "DoubleClick", ...)</summary> **/
        public Init Event(string eventType, System.EventHandler method)
        {
            if(eventType.ToLower() == "Click".ToLower())
                ExtControl.Click += new System.EventHandler(method);

            if(eventType.ToLower() == "DoubleClick".ToLower())
                ExtControl.DoubleClick += new System.EventHandler(method);

            if(eventType.ToLower() == "MouseCaptureChanged".ToLower())
                ExtControl.MouseCaptureChanged += new System.EventHandler(method);

            if(eventType.ToLower() == "MouseClick".ToLower())
                ExtControl.MouseClick += new System.Windows.Forms.MouseEventHandler(method);

            if(eventType.ToLower() == "MouseDoubleClick".ToLower())
                ExtControl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(method);

            if(eventType.ToLower() == "Paint".ToLower())
                ExtControl.Paint += new System.Windows.Forms.PaintEventHandler(method);

            if(eventType.ToLower() == "DragDrop".ToLower())
                ExtControl.DragDrop += new System.Windows.Forms.DragEventHandler(method);

            if(eventType.ToLower() == "DragEnter".ToLower())
                ExtControl.DragEnter += new System.Windows.Forms.DragEventHandler(method);

            if(eventType.ToLower() == "DragLeave".ToLower())
                ExtControl.DragLeave += new System.EventHandler(method);

            if(eventType.ToLower() == "DragOver".ToLower())
                ExtControl.DragOver += new System.Windows.Forms.DragEventHandler(method);

            if(eventType.ToLower() == "GiveFeedback".ToLower())
                ExtControl.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(method);

            if(eventType.ToLower() == "QueryContinueDrag".ToLower())
                ExtControl.QueryContinueDrag += new System.Windows.Forms.QueryContinueDragEventHandler(method);

            if(eventType.ToLower() == "Enter".ToLower())
                ExtControl.Enter += new System.EventHandler(method);

            if(eventType.ToLower() == "Leave".ToLower())
                ExtControl.Leave += new System.EventHandler(method);

            if(eventType.ToLower() == "Validated".ToLower())
                ExtControl.Validated += new System.EventHandler(method);

            if(eventType.ToLower() == "Validating".ToLower())
                ExtControl.Validating += new System.ComponentModel.CancelEventHandler(method);

            if(eventType.ToLower() == "AutoSizeChanged".ToLower())
                ExtControl.AutoSizeChanged += new System.EventHandler(method);

            if(eventType.ToLower() == "BackColorChanged".ToLower())
                ExtControl.BackColorChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "BackgroundImageChanged".ToLower())
                ExtControl.BackgroundImageChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "BindingContextChanged".ToLower())
                ExtControl.BindingContextChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "CausesValidationChanged".ToLower())
                ExtControl.CausesValidationChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "ClientSizeChanged".ToLower())
                ExtControl.ClientSizeChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "ContextMenuStripChanged".ToLower())
                ExtControl.ContextMenuStripChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "CursorChanged".ToLower())
                ExtControl.CursorChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "DockChanged".ToLower())
                ExtControl.DockChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "EnabledChanged".ToLower())
                ExtControl.EnabledChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "FontChanged".ToLower())
                ExtControl.FontChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "ForeColorChanged".ToLower())
                ExtControl.ForeColorChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "LocationChanged".ToLower())
                ExtControl.LocationChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "RegionChanged".ToLower())
                ExtControl.RegionChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "RightToLeftChanged".ToLower())
                ExtControl.RightToLeftChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "SizeChanged".ToLower())
                ExtControl.SizeChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "TabIndexChanged".ToLower())
                ExtControl.TabIndexChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "TabStopChanged".ToLower())
                ExtControl.TabStopChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "TextChanged".ToLower())
                ExtControl.TextChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "VisibleChanged".ToLower())
                ExtControl.VisibleChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "ParentChanged".ToLower())
                ExtControl.ParentChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "DpiChangedBeforeParent".ToLower())
                ExtControl.DpiChangedBeforeParent += new System.EventHandler(method);

            if (eventType.ToLower() == "DpiChangedAfterParent".ToLower())
                ExtControl.DpiChangedAfterParent += new System.EventHandler(method);

            if (eventType.ToLower() == "Layout".ToLower())
                ExtControl.Layout += new System.Windows.Forms.LayoutEventHandler(method);

            if (eventType.ToLower() == "Resize".ToLower())
                ExtControl.Resize += new System.EventHandler(method);

            if (eventType.ToLower() == "Move".ToLower())
                ExtControl.Move += new System.EventHandler(method);

            if (eventType.ToLower() == "PaddingChanged".ToLower())
                ExtControl.PaddingChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "MarginChanged".ToLower())
                ExtControl.MarginChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "MouseDown".ToLower())
                ExtControl.MouseDown += new System.Windows.Forms.MouseEventHandler(method);

            if (eventType.ToLower() == "MouseMove".ToLower())
                ExtControl.MouseMove += new System.Windows.Forms.MouseEventHandler(method);

            if (eventType.ToLower() == "MouseUp".ToLower())
                ExtControl.MouseUp += new System.Windows.Forms.MouseEventHandler(method);

            if (eventType.ToLower() == "MouseEnter".ToLower())
                ExtControl.MouseEnter += new System.EventHandler(method);

            if (eventType.ToLower() == "MouseLeave".ToLower())
                ExtControl.MouseLeave += new System.EventHandler(method);

            if (eventType.ToLower() == "MouseHover".ToLower())
                ExtControl.MouseHover += new System.EventHandler(method);

            if (eventType.ToLower() == "PreviewKeyDown".ToLower())
                ExtControl.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(method);

            if (eventType.ToLower() == "KeyUp".ToLower())
                ExtControl.KeyUp += new System.Windows.Forms.KeyEventHandler(method);

            if (eventType.ToLower() == "KeyPress".ToLower())
                ExtControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(method);

            if (eventType.ToLower() == "KeyDown".ToLower())
                ExtControl.KeyDown += new System.Windows.Forms.KeyEventHandler(method);

            if (eventType.ToLower() == "ControlAdded".ToLower())
                ExtControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(method);

            if (eventType.ToLower() == "ControlRemoved".ToLower())
                ExtControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(method);

            if (eventType.ToLower() == "HelpRequested".ToLower())
                ExtControl.HelpRequested += new System.Windows.Forms.HelpEventHandler(method);

            if (eventType.ToLower() == "QueryAccessibilityHelp".ToLower())
                ExtControl.QueryAccessibilityHelp += new System.Windows.Forms.QueryAccessibilityHelpEventHandler(method);

            if (eventType.ToLower() == "ChangeUICues".ToLower())
                ExtControl.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(method);

            if (eventType.ToLower() == "StyleChanged".ToLower())
                ExtControl.StyleChanged += new System.EventHandler(method);

            if (eventType.ToLower() == "SystemColorsChanged".ToLower())
                ExtControl.SystemColorsChanged += new System.EventHandler(method);

            return this;
        }

        /** <summary>Converts the CNest control back to the normal control. After this, you can use again every other default method, which isn't available in this script</summary> **/
        public System.Windows.Forms.Control Get()
        {
            return ExtControl;
        }
    }

    public class Util
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
            static extern int GetWindowLong(System.IntPtr hWnd, int nIndex);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
            static extern int SetWindowLong(System.IntPtr hWnd, int nIndex, int dwNewLong);

        /** <summary>CNest Util: Change the normal window to a layer window.</summary> **/
        public void ChangeToLayer(System.IntPtr Handle)
        {
            int GWL_EXSTYLE = -20;
            int WS_EX_LAYERED = 0x80000;
            int WS_EX_TRANSPARENT = 0x20;

            var style = GetWindowLong(Handle, GWL_EXSTYLE);

            SetWindowLong(Handle, GWL_EXSTYLE, style | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private static bool isAltMaximized = false;
        private static int altWindowWidth = 0;
        private static int altWindowHeight = 0;
        private static System.Drawing.Point altWindowCoords = new System.Drawing.Point(0, 0);

        /** <summary>CNest Util: Maximize the window</summary> **/
        public static void MaximizeWindow(bool alternativeMode = false)
        {
            if (!alternativeMode)
            {
                System.Windows.Forms.Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            }
            else
            {
                Init UtilMW = new Init();

                altWindowWidth = UtilMW._(System.Windows.Forms.Form.ActiveForm).Width();
                altWindowHeight = UtilMW._(System.Windows.Forms.Form.ActiveForm).Height();
                altWindowCoords = System.Windows.Forms.Form.ActiveForm.Location;

                UtilMW._(System.Windows.Forms.Form.ActiveForm)
                    .Move(0, 0)
                    .Width(System.Windows.Forms.Screen.FromControl(System.Windows.Forms.Form.ActiveForm).WorkingArea.Width)
                    .Height(System.Windows.Forms.Screen.FromControl(System.Windows.Forms.Form.ActiveForm).WorkingArea.Height);
            }

            isAltMaximized = alternativeMode;
        }

        /** <summary>CNest Util: Minimize the Window</summary> **/
        public static void MinimizeWindow()
        {
            System.Windows.Forms.Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        /** <summary>CNest Util: Normalize the window</summary> **/
        public static void NormalWindow()
        {
            System.Windows.Forms.Form.ActiveForm.WindowState = System.Windows.Forms.FormWindowState.Normal;
            if(isAltMaximized)
            {
                Init UtilMW = new Init();

                UtilMW._(System.Windows.Forms.Form.ActiveForm)
                    .Move(altWindowCoords.X, altWindowCoords.Y)
                    .Width(altWindowWidth)
                    .Height(altWindowHeight);

                isAltMaximized = false;
            }
        }

        /** <summary>CNest Util: Returns the window state ("Maximized", "Minimized", "Normal")</summary> **/
        public static string WindowState()
        {
            if (System.Windows.Forms.Form.ActiveForm.WindowState == System.Windows.Forms.FormWindowState.Maximized || isAltMaximized)
                return "Maximized";
            if (System.Windows.Forms.Form.ActiveForm.WindowState == System.Windows.Forms.FormWindowState.Minimized)
                return "Minimized";
            if (System.Windows.Forms.Form.ActiveForm.WindowState == System.Windows.Forms.FormWindowState.Normal)
                return "Normal";
            return "Normal";
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern System.IntPtr GetDC(System.IntPtr hwnd);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
            private static extern System.Int32 ReleaseDC(System.IntPtr hwnd, System.IntPtr hdc);

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
            private static extern uint GetPixel(System.IntPtr hdc, int nXPos, int nYPos);

        /** <summary>CNest Util: Returns the color of the pixel at x, y</summary> **/
        public System.Drawing.Color GetPixelColor(int x, int y)
        {
            System.IntPtr hdc = GetDC(System.IntPtr.Zero);

            uint pixel = GetPixel(hdc, x, y);

            ReleaseDC(System.IntPtr.Zero, hdc);

            System.Drawing.Color color = System.Drawing.Color.FromArgb((int)(pixel & 0x000000FF),
                         (int)(pixel & 0x0000FF00) >> 8,
                         (int)(pixel & 0x00FF0000) >> 16);

            return color;
        }

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
            private static extern int SendMessage(System.IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
            private static extern bool ReleaseCapture();

        /** <summary>CNest Util: Combine this with a "MouseDown"-event to make the window movable. (Perfect to create custom titlebars)</summary> **/
        static public void MoveWindow()
        {
            if (!isAltMaximized)
            {
                ReleaseCapture();
                SendMessage(System.Windows.Forms.Form.ActiveForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        /** <summary>CNest Util: Resize and push into the given array (BETA)</summary> **/
        static public void PushArray<T>(ref T[] array, ref T value)
        {
            System.Array.Resize(ref array, array.Length + 1);
            array[array.GetUpperBound(0)] = value;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
            private static extern bool AllocConsole();

        [System.Runtime.InteropServices.DllImport("kernel32.dll", SetLastError = true)]
        [return: System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.Bool)]
            private static extern bool FreeConsole();

        /** <summary>CNest Util: Adds a console to the window application or removes it again</summary> **/
        public static bool Console(bool show)
        {
            if (show)
            {
                return AllocConsole();
            }
            else
            {
                return FreeConsole();
            }
        }

        /** <summary>CNest Util: Encodes a normal string into Base64</summary> **/
        public static string EncodeBase64(string text)
        {
            byte[] data = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            return System.Convert.ToBase64String(data);
        }

        /** <summary>CNest Util: Decodes a normal string from Base64</summary> **/
        public static string DecodeBase64(string text)
        {
            byte[] data = System.Convert.FromBase64String(text);
            return System.Text.ASCIIEncoding.ASCII.GetString(data);
        }

        public class Hash
        {
            /** <summary>CNest Util: Creates a MD5 Hash from any text</summary> **/
            public static string MD5(string text)
            {
                System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = md5.ComputeHash(data);

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }

            /** <summary>CNest Util: Creates a SHA1 Hash from any text</summary> **/
            public static string SHA1(string text)
            {
                System.Security.Cryptography.SHA1 sha1 = System.Security.Cryptography.SHA1.Create();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = sha1.ComputeHash(data);

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }

            /** <summary>CNest Util: Creates a SHA256 Hash from any text</summary> **/
            public static string SHA256(string text)
            {
                System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = sha256.ComputeHash(data);

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }

            /** <summary>CNest Util: Creates a SHA384 Hash from any text</summary> **/
            public static string SHA384(string text)
            {
                System.Security.Cryptography.SHA384 sha384 = System.Security.Cryptography.SHA384.Create();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = sha384.ComputeHash(data);

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }

            /** <summary>CNest Util: Creates a SHA512 Hash from any text</summary> **/
            public static string SHA512(string text)
            {
                System.Security.Cryptography.SHA512 sha512 = System.Security.Cryptography.SHA512.Create();

                byte[] data = System.Text.Encoding.ASCII.GetBytes(text);
                byte[] hash = sha512.ComputeHash(data);

                System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder();

                for (int i = 0; i < hash.Length; i++)
                {
                    stringBuilder.Append(hash[i].ToString("X2"));
                }

                return stringBuilder.ToString();
            }
        }

        /** <summary>CNest Util: Returns the path of special folders ("this" = exe's own path, "appdata" = appdata path, ...)</summary> **/
        public static string Path(string shortcut = "this")
        {
            shortcut = shortcut.ToLower().Replace("%", "").Replace(" ", "").Replace("-", "").Replace("_", "");

            string path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);

            if (shortcut == "this")
            {
                path = System.IO.Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath);
            }
            else if (shortcut == "appdata")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ApplicationData);
            }
            else if (shortcut == "programdata")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CommonApplicationData);
            }
            else if (shortcut == "local")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            }
            else if (shortcut == "personal")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            }
            else if (shortcut == "user")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            }
            else if (shortcut == "documents")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
            }
            else if (shortcut == "music")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyMusic);
            }
            else if (shortcut == "pictures")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            }
            else if (shortcut == "videos")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyVideos);
            }
            else if (shortcut == "programfiles")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
            }
            else if (shortcut == "programfiles86" || shortcut == "programfilesx86" || shortcut == "programfiles32" || shortcut == "programfilesx32")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFilesX86);
            }
            else if (shortcut == "admintools")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.AdminTools);
            }
            else if (shortcut == "burn" || shortcut == "cdburning")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.CDBurning);
            }
            else if (shortcut == "desktopdirectory")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            }
            else if (shortcut == "programs")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Programs);
            }
            else if (shortcut == "startmenu")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.StartMenu);
            }
            else if (shortcut == "startup")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Startup);
            }
            else if (shortcut == "sendto")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.SendTo);
            }
            else if (shortcut == "templates")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Templates);
            }
            else if (shortcut == "cookies")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Cookies);
            }
            else if (shortcut == "desktop")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);
            }
            else if (shortcut == "favorits")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Favorites);
            }
            else if (shortcut == "fonts")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Fonts);
            }
            else if (shortcut == "history")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.History);
            }
            else if (shortcut == "internetcache")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.InternetCache);
            }
            else if (shortcut == "computer")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyComputer);
            }
            else if (shortcut == "networkshortcuts")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.NetworkShortcuts);
            }
            else if (shortcut == "recent")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Recent);
            }
            else if (shortcut == "resources")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Resources);
            }
            else if (shortcut == "system")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.System);
            }
            else if (shortcut == "system86" || shortcut == "systemx86" || shortcut == "system32" || shortcut == "systemx32")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.SystemX86);
            }
            else if (shortcut == "windows")
            {
                path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Windows);
            }

            return path;
        }

        private int RGBR = 255;
        private int RGBRStep = 1;
        private int RGBG = 50;
        private int RGBGStep = 1;
        private int RGBB = 0;
        private int RGBBStep = 1;

        /** <summary>CNest Util: Returns a smooth RGB color change. Recommend: Usage with timer. Every call = a new color</summary> **/
        public System.Drawing.Color RGBColor()
        {
            if (RGBR >= 254)
            {
                RGBRStep = -1;
            }
            else if (RGBR <= 1)
            {
                RGBRStep = 1;
            }
            if (RGBG >= 254)
            {
                RGBGStep = -1;
            }
            else if (RGBG <= 1)
            {
                RGBGStep = 1;
            }
            if (RGBB >= 254)
            {
                RGBBStep = -1;
            }
            else if (RGBB <= 1)
            {
                RGBBStep = 1;
            }

            RGBR += RGBRStep;
            RGBG += RGBGStep;
            RGBB += RGBBStep;

            return System.Drawing.Color.FromArgb(RGBR, RGBG, RGBB);
        }

        /** <summary>CNest Util: Returns a random generated RGB color</summary> **/
        public System.Drawing.Color RandomColor()
        {
            return System.Drawing.Color.FromArgb(Rand(0, 255), Rand(0, 255), Rand(0, 255));
        }

        /** <summary>CNest Util: Returns the invertation of the given color</summary> **/
        public System.Drawing.Color InvertColor(System.Drawing.Color color)
        {
            return System.Drawing.Color.FromArgb(color.ToArgb() ^ 0xffffff);
        }

        /** <summary>CNest Util: Returns a random generated number between min to max</summary> **/
        public int Rand(int min, int max)
        {
            System.Random rand = new System.Random();
            return rand.Next(min, max);
        }

        /** <summary>CNest Util: Returns a close symbol</summary> **/
        public static string GetCloseSymbol(bool biggerSymbol = false)
        {
            if(biggerSymbol)
            {
                return "\u2715";
            }

            return "\u00D7";
        }

        /** <summary>CNest Util: Returns a maximize symbol</summary> **/
        public static string GetMaximizeSymbol()
        {
            return "\uD83D\uDDD6";
        }

        /** <summary>CNest Util: Returns a normalize symbol</summary> **/
        public static string GetNormalizeSymbol()
        {
            return "\uD83D\uDDD7";
        }

        /** <summary>CNest Util: Returns a minimize symbol</summary> **/
        public static string GetMinimizeSymbol()
        {
            return "\uD83D\uDDD5";
        }

        /** <summary>CNest Util: Creates a screenshot of the given screen</summary> **/
        public static System.Drawing.Bitmap DoScreenshot(System.Windows.Forms.Screen screen)
        {
            var bitmap = new System.Drawing.Bitmap(screen.Bounds.Width, screen.Bounds.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            var screenshotArea = System.Drawing.Graphics.FromImage(bitmap);

            screenshotArea.CopyFromScreen(screen.Bounds.X,
                                        screen.Bounds.Y,
                                        0,
                                        0,
                                        screen.Bounds.Size,
                                        System.Drawing.CopyPixelOperation.SourceCopy);
            return bitmap;
        }

        /** <summary>CNest Util: Saves a bitmap to the given filepath</summary> **/
        public static void SaveBitmap(System.Drawing.Bitmap bitmap, string filepath)
        {
            bitmap.Save(filepath, System.Drawing.Imaging.ImageFormat.Png);
        }

        /** <summary>CNest Util: Crops a bitmap</summary> **/
        public static System.Drawing.Bitmap CropBitmap(System.Drawing.Bitmap bitmap, int x, int y, int width, int height)
        {
            System.Drawing.Bitmap area = new System.Drawing.Bitmap(width, height);
            using (System.Drawing.Graphics areaGraphic = System.Drawing.Graphics.FromImage(area))
            {
                areaGraphic.DrawImage(bitmap, -x, -y);
                return area;
            }
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern ushort GetAsyncKeyState(int vKey);

        public static bool GetAsyncKeyState(System.Windows.Forms.Keys vKey)
        {
            return 0 != (GetAsyncKeyState((int)vKey) & 0x8000);
        }

        public static int KeysToInt(System.Windows.Forms.Keys vKey)
        {
            return (int)vKey;
        }

        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        public static extern long GetVolumeInformation(
        string PathName,
        System.Text.StringBuilder VolumeNameBuffer,
        System.UInt32 VolumeNameSize,
        ref System.UInt32 VolumeSerialNumber,
        ref System.UInt32 MaximumComponentLength,
        ref System.UInt32 FileSystemFlags,
        System.Text.StringBuilder FileSystemNameBuffer,
        System.UInt32 FileSystemNameSize);

        /** <summary>CNest Util: Get the users HWID</summary> **/
        public static System.String HWID(
            bool sha512Hashed, 
            bool volumeSerialNumber, 
            bool volumeMaxComponentLengh, 
            bool volumeFileSystemName,
            bool computerName
        )
        {
            System.String hwid = "";

            if(volumeSerialNumber || volumeMaxComponentLengh || volumeFileSystemName)
            {
                try
                {
                    string drive_letter = "C:\\";
                    drive_letter = drive_letter.Substring(0, 1) + ":\\";

                    uint serial_number = 0;
                    uint max_component_length = 0;
                    System.Text.StringBuilder sb_volume_name = new System.Text.StringBuilder(256);
                    System.UInt32 file_system_flags = new System.UInt32();
                    System.Text.StringBuilder sb_file_system_name = new System.Text.StringBuilder(256);

                    if (GetVolumeInformation(drive_letter, sb_volume_name,
                        (System.UInt32)sb_volume_name.Capacity, ref serial_number,
                        ref max_component_length, ref file_system_flags,
                        sb_file_system_name,
                        (System.UInt32)sb_file_system_name.Capacity) == 0)
                    {
                        hwid += "";
                    }
                    else
                    {
                        if (volumeSerialNumber)
                        {
                            hwid += serial_number.ToString();
                        }
                        if (volumeMaxComponentLengh)
                        {
                            hwid += max_component_length.ToString();
                        }
                        if (volumeFileSystemName)
                        {
                            hwid += sb_file_system_name.ToString();
                        }
                    }
                }
                catch (System.Exception) { hwid += ""; }

                if(computerName)
                {
                    try
                    {
                        hwid += System.Environment.MachineName;
                    }
                    catch (System.Exception) { hwid += ""; };
                }
            }

            if(sha512Hashed)
            {
                return Util.Hash.SHA512(hwid);
            }
            return hwid;
        }
    }

    public class IniFile
    {
        private string Path;

        private string EXE = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

        [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            private static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [System.Runtime.InteropServices.DllImport("kernel32", CharSet = System.Runtime.InteropServices.CharSet.Unicode)]
            private static extern int GetPrivateProfileString(string Section, string Key, string Default, System.Text.StringBuilder RetVal, int Size, string FilePath);

        /** <summary>CNest Scripts[ini]: External embedded script to read and write ini-files</summary> **/
        public IniFile(string IniPath = null)
        {
            Path = new System.IO.FileInfo(IniPath ?? (EXE + ".ini")).FullName.ToString();
        }

        /** <summary>CNest Scripts[ini]: Reads a string of an ini file</summary> **/
        public string Read(string Key, string Section = null)
        {
            System.Text.StringBuilder stringBuilder = new System.Text.StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", stringBuilder, 255, Path);
            return stringBuilder.ToString();
        }

        /** <summary>CNest Scripts[ini]: Writes a string into an ini file</summary> **/
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }

        /** <summary>CNest Scripts[ini]: Deletes a key of an ini file</summary> **/
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }

        /** <summary>CNest Scripts[ini]: Deletes a section of an ini file</summary> **/
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }

        /** <summary>CNest Scripts[ini]: Checks if a key exist in an ini file</summary> **/
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }

    public class AES
    {
        System.Security.Cryptography.AesCryptoServiceProvider crypto_provider;

        /** <summary>CNest Scripts[aes]: External embedded script to encrypt / decrypt AES</summary> **/
        public AES(string key = "Jj2BzcCutd5ntXu2Z8HqD5i23VAdir5n", string IV = "lksguldusfgiulsg")
        {
            crypto_provider = new System.Security.Cryptography.AesCryptoServiceProvider();

            crypto_provider.BlockSize = 128;
            crypto_provider.KeySize = 256;
            crypto_provider.Key = System.Text.ASCIIEncoding.ASCII.GetBytes(key);
            crypto_provider.IV = System.Text.ASCIIEncoding.ASCII.GetBytes(IV);
            crypto_provider.Mode = System.Security.Cryptography.CipherMode.CBC;
            crypto_provider.Padding = System.Security.Cryptography.PaddingMode.PKCS7;
        }

        /** <summary>CNest Scripts[aes]: Encrypts a string into an Base64 encoded AES string</summary> **/
        public System.String encryptBase64(System.String clear_text)
        {
            System.Security.Cryptography.ICryptoTransform transform = crypto_provider.CreateEncryptor();

            byte[] encrypted_bytes = transform.TransformFinalBlock(System.Text.ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);

            string str = System.Convert.ToBase64String(encrypted_bytes);
            return str;
        }

        /** <summary>CNest Scripts[aes]: Encrypts a string into an AES string</summary> **/
        public byte[] encrypt(System.String clear_text)
        {
            System.Security.Cryptography.ICryptoTransform transform = crypto_provider.CreateEncryptor();

            byte[] encrypted_bytes = transform.TransformFinalBlock(System.Text.ASCIIEncoding.ASCII.GetBytes(clear_text), 0, clear_text.Length);

            return encrypted_bytes;
        }

        /** <summary>CNest Scripts[aes]: Decrypts an Base64 Encoded AES string into a normal string</summary> **/
        public System.String decryptBase64(System.String cipher_text)
        {
            System.Security.Cryptography.ICryptoTransform transform = crypto_provider.CreateDecryptor();

            byte[] enc_bytes = System.Convert.FromBase64String(cipher_text);
            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = System.Text.ASCIIEncoding.ASCII.GetString(decrypted_bytes);
            return str;
        }

        /** <summary>CNest Scripts[aes]: Decrypts an AES string into a normal string</summary> **/
        public System.String decrypt(byte[] cipher_text)
        {
            System.Security.Cryptography.ICryptoTransform transform = crypto_provider.CreateDecryptor();

            byte[] enc_bytes = cipher_text;
            byte[] decrypted_bytes = transform.TransformFinalBlock(enc_bytes, 0, enc_bytes.Length);

            string str = System.Text.ASCIIEncoding.ASCII.GetString(decrypted_bytes);
            return str;
        }
    }

    public class CMD
    {
        /** <summary>CNest Scripts[CMD]: Sets the title of the console</summary> **/
        public static void Title(System.String title)
        {
            System.Console.Title = title;
        }

        /** <summary>CNest Scripts[CMD]: Clears the whole console/line</summary> **/
        public static void Clear(bool line = false)
        {
            if (line)
            {
                System.Console.Write("\r" + new string(' ', System.Console.WindowWidth - 1) + "\r");
            }
            else
            {
                System.Console.Clear();
            }
        }

        /** <summary>CNest Scripts[CMD]: Writes a text in a console line</summary> **/
        public static void WL(System.String text)
        {
            System.Console.WriteLine(text);
        }

        /** <summary>CNest Scripts[CMD]: Writes a text in a console</summary> **/
        public static void W(System.String text)
        {
            System.Console.Write(text);
        }

        /** <summary>CNest Scripts[CMD]: Reads a text in a console line</summary> **/
        public static System.String RL(System.String text = "")
        {
            if(text != "")
            {
                System.Console.Write(text);
            }
            return System.Console.ReadLine();
        }

        /** <summary>CNest Scripts[CMD]: Reads a text in a console</summary> **/
        public static int R(System.String text = "")
        {
            if(text != "")
            {
                System.Console.Write(text);
            }
            return System.Console.Read();
        }

        /** <summary>CNest Scripts[CMD]: Pauses the console application until key press</summary> **/
        public static void Pause()
        {
            System.Console.ReadKey();
        }
    }
}
