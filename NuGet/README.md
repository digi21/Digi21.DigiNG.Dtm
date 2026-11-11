# Digi21.DigiNG.Dtm

This package contains a reference assembly to open digital terrain models (.mdt) of [Digi3D.AI](https://www.digi21.net/Digi3D) and obtain the terrain Z coordinate at a point's X and Y coordinates.

The runtime assemblies are installed by Digi3D.AI 2027.0.0.428 or later. The Digi21.DigiNG package, which this package depends on, adds a source file to your C# project that locates the runtime assemblies in the Digi3D.AI installation folder, so your console application or extension can be installed in any folder. Locating the runtime assemblies requires no additional package or application code.

```csharp
using var dtm = DigitalTerrainModel.Open(@"C:\Data\terrain.mdt");
var models = new DigitalTerrainModelCollection();
models.Add(dtm, "terrain");
double? z = models.Project(point, "terrain");
```

Pass `models.Project` as the `projectZ` parameter of `TopologyAnalyzer.CreatePolygons` in the Digi21.DigiNG.Topology package.

A Digi3D.AI license is required to run applications that use the assemblies published by this package. [Rent](https://www.digi21.net/Tienda/Alquiler) or [buy](https://www.digi21.net/Tienda/Compra) a license.