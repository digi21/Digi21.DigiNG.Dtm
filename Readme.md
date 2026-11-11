[![NuGet](https://img.shields.io/nuget/v/Digi21.DigiNG.Dtm?style=flat)](https://www.nuget.org/packages/Digi21.DigiNG.Dtm/)

# Digi21.DigiNG.Dtm

This repository contains the source code of the reference assembly Digi21.DigiNG.Dtm, which is distributed through a NuGet package to open digital terrain models (.mdt) of Digi3D.AI and obtain the terrain Z coordinate at a point's X and Y coordinates.

## Example

```csharp
using Digi21.DigiNG.Dtm;
using Digi21.DigiNG.Topology;

using var dtm = DigitalTerrainModel.Open(@"C:\Data\terrain.mdt");

var models = new DigitalTerrainModelCollection();
models.Add(dtm, "terrain");

// models.Project(Point3D, string) has the signature that the projectZ parameter expects.
var polygons = TopologyAnalyzer.CreatePolygons(loops, topology, models.Project);
```

A single model can also be used directly: `double? z = dtm.Project(point);` returns the terrain Z coordinate at the X and Y coordinates of `point`, or null if the model does not cover it.

## Requirements

The package contains only a reference assembly. The runtime assemblies are installed by Digi3D.AI 2027.0.0.428 or later, and a Digi3D.AI license is required to run applications that use them.

## Publishing

Push a tag `v<version>` whose version matches `<version>` in the `.nuspec` of the `NuGet` folder. The *Release* workflow builds the reference assembly, packs it and publishes it to nuget.org by exchanging a GitHub Actions identity token for a temporary NuGet access key (trusted publishing; repository secret `NUGET_USER`, the nuget.org profile name). The packages are not author-signed; the reference assembly is public-signed with `Digi21.PublicKey.snk`, which contains only the public key.