// 系统引用
global using Autodesk.AutoCAD;
// autocad 引用
global using Autodesk.AutoCAD.ApplicationServices;
global using Autodesk.AutoCAD.Colors;
global using Autodesk.AutoCAD.DatabaseServices;
global using Autodesk.AutoCAD.DatabaseServices.Filters;
global using Autodesk.AutoCAD.EditorInput;
global using Autodesk.AutoCAD.Geometry;
global using Autodesk.AutoCAD.GraphicsInterface;
global using Autodesk.AutoCAD.Runtime;
global using IFoxCAD.Basal;
/// ifoxcad
global using IFoxCAD.Cad;
global using Microsoft.Win32;
global using System;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.IO;
global using System.Linq;
global using System.Runtime.InteropServices;
global using System.Text;
global using System.Threading;
global using Acaop = Autodesk.AutoCAD.ApplicationServices.Core.Application;
global using Acap = Autodesk.AutoCAD.ApplicationServices.Application;
global using Acgi = Autodesk.AutoCAD.GraphicsInterface;
global using Cad_DwgFiler = Autodesk.AutoCAD.DatabaseServices.DwgFiler;
global using Cad_DxfFiler = Autodesk.AutoCAD.DatabaseServices.DxfFiler;
global using Cad_ErrorStatus = Autodesk.AutoCAD.Runtime.ErrorStatus;
global using Group = Autodesk.AutoCAD.DatabaseServices.Group;
global using Manager = Autodesk.AutoCAD.GraphicsSystem.Manager;
global using Polyline = Autodesk.AutoCAD.DatabaseServices.Polyline;
global using Registry = Microsoft.Win32.Registry;
global using Viewport = Autodesk.AutoCAD.DatabaseServices.Viewport;
// jig命名空间会引起Viewport/Polyline等等重义,最好逐个引入 using Autodesk.AutoCAD.GraphicsInterface
global using WorldDraw = Autodesk.AutoCAD.GraphicsInterface.WorldDraw;

