using Digi21.Math;
using System;

namespace Digi21.DigiNG.Dtm
{
    /// <summary>
    /// Digital terrain model represented by a triangulated irregular network (TIN), read from an MDTopX .mdt file, that returns the terrain Z coordinate of a point.
    /// </summary>
    /// <remarks>
    /// <see cref="Open"/> loads the MDTopX libraries (CoreTri.dll and its dependencies) from the directory two levels above the assembly directory or, if CoreTri.dll is not there, from the assembly directory.
    /// </remarks>
    public sealed class DigitalTerrainModel : IDisposable
    {
        private DigitalTerrainModel() => throw null;

        /// <summary>
        /// Reads a whole MDTopX digital terrain model (.mdt) file in the calling thread.
        /// </summary>
        /// <param name="filePath">Path of the .mdt file.</param>
        /// <returns>The digital terrain model. Dispose it to release the memory of its triangles.</returns>
        /// <remarks>
        /// <see cref="Open"/> does not show dialog boxes, does not check the license and does not create the .prj file of the
        /// coordinate system: <see cref="Open"/> reads the .prj file, if present, to populate <see cref="CoordinateSystemWkt"/>.
        /// </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="filePath"/> is null.</exception>
        /// <exception cref="NotSupportedException">The extension of <paramref name="filePath"/> is not .mdt (case-insensitive).</exception>
        /// <exception cref="System.IO.FileNotFoundException">The file does not exist.</exception>
        /// <exception cref="System.IO.IOException">The file exists but cannot be opened.</exception>
        /// <exception cref="System.IO.InvalidDataException">The file is not a valid MDTopX digital terrain model.</exception>
        /// <exception cref="DllNotFoundException">CoreTri.dll was found neither in the directory two levels above the assembly directory nor in the assembly directory, or an MDTopX library could not be loaded.</exception>
        public static DigitalTerrainModel Open(string filePath) => throw null;

        /// <summary>
        /// Full path of the .mdt file.
        /// </summary>
        public string FilePath => throw null;

        /// <summary>
        /// First line of the .prj file next to the .mdt file, with the same base name as the .mdt file, containing the coordinate system
        /// definition in Well-Known Text (WKT) format.
        /// Returns null if the .prj file does not exist.
        /// </summary>
        public string CoordinateSystemWkt => throw null;

        /// <summary>
        /// Minimum and maximum coordinates of the model, in terrain coordinates.
        /// </summary>
        public Window3D Bounds => throw null;

        /// <summary>
        /// Returns the Z coordinate of the terrain at the X and Y coordinates of a point.
        /// </summary>
        /// <param name="groundPoint">Point in terrain coordinates. <see cref="Project"/> ignores its Z coordinate.</param>
        /// <returns>
        /// The terrain Z coordinate at the point's X and Y coordinates in the containing triangle, or null if the point is outside the limits of the model or of all its
        /// triangles, if its X or Y coordinate is not finite, or if its X or Y coordinate, converted to the integer coordinates of the model, does
        /// not fit in a 32-bit integer.
        /// </returns>
        /// <remarks>
        /// <para>
        /// Several threads can call <see cref="Project"/> at the same time. Do not dispose the model while a call to <see cref="Project"/> is in progress.
        /// </para>
        /// <para>
        /// For a point on an edge shared by two triangles, rounding can make the Z coordinate returned by <see cref="Project"/> differ from the Z coordinate returned by
        /// Digi3D.AI for the same model. The difference measured at one point on a shared edge was 2 mm.
        /// </para>
        /// </remarks>
        /// <exception cref="ObjectDisposedException">The model has been disposed.</exception>
        public double? Project(Point3D groundPoint) => throw null;

        /// <summary>
        /// Releases the triangles of the model.
        /// </summary>
        public void Dispose() => throw null;
    }
}