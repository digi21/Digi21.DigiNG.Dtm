using Digi21.Math;
using System;

namespace Digi21.DigiNG.Dtm
{
    /// <summary>
    /// Set of digital terrain models, each one with a tag, that returns the terrain Z coordinate of a point.
    /// Queries models with the requested tag, or models with any tag when the requested tag is null or empty, and returns the first
    /// non-null terrain Z coordinate.
    /// </summary>
    /// <remarks>
    /// The collection does not call <see cref="IDisposable.Dispose"/> on its models: dispose each <see cref="DigitalTerrainModel"/> after the last call to <see cref="Project"/>.
    /// </remarks>
    public sealed class DigitalTerrainModelCollection
    {
        /// <summary>
        /// Creates an empty collection.
        /// </summary>
        public DigitalTerrainModelCollection() => throw null;

        /// <summary>
        /// Adds a digital terrain model with a tag.
        /// </summary>
        /// <param name="model">Digital terrain model.</param>
        /// <param name="tag">Tag of the model. A null tag is stored as an empty tag.</param>
        /// <remarks>
        /// Do not call <see cref="Add"/> while another thread is calling <see cref="Project"/>.
        /// </remarks>
        /// <exception cref="ArgumentNullException"><paramref name="model"/> is null.</exception>
        public void Add(DigitalTerrainModel model, string tag) => throw null;

        /// <summary>
        /// Number of models added.
        /// </summary>
        public int Count => throw null;

        /// <summary>
        /// Returns the Z coordinate of the terrain at the X and Y coordinates of a point, from the first model that contains it.
        /// </summary>
        /// <param name="groundPoint">Point in terrain coordinates. <see cref="Project"/> ignores its Z coordinate.</param>
        /// <param name="tag">
        /// Tag of the models to query, compared with ordinal, case-sensitive comparison. If <paramref name="tag"/> is null or empty,
        /// <see cref="Project"/> queries all the models, grouped by tag in ordinal order of the tag and, within each tag, in the order in
        /// which they were added.
        /// </param>
        /// <returns>
        /// The value that <see cref="DigitalTerrainModel.Project"/> returns for the first model that returns a Z coordinate.
        /// Returns null if no queried model returns a Z coordinate. A null or empty tag selects models with any tag.
        /// </returns>
        /// <remarks>
        /// Several threads can call <see cref="Project"/> at the same time. The signature matches the projectZ parameter of
        /// Digi21.DigiNG.Topology.TopologyAnalyzer.CreatePolygon and CreatePolygons.
        /// </remarks>
        /// <exception cref="ObjectDisposedException">A model queried has been disposed.</exception>
        public double? Project(Point3D groundPoint, string tag) => throw null;
    }
}