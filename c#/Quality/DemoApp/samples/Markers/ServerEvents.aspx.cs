﻿using System;
using System.Web.UI;
using GoogleMaps.Markers;

namespace GoogleMaps.Samples.Markers
{
    public partial class ServerEvents : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var marker = new Marker();
            marker.Position = new LatLng(42.1229, 24.7879);
            marker.Title = "Test";
            marker.Draggable = true;
            marker.Clickable = true;
            //marker.Animation = true;
            //marker.Shadow = true;
            GoogleMarkers1.Markers.Add(marker);
        }

        /// <summary>
        /// Handles the animation changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleAnimationChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("AnimationChanged", e);
        }

        /// <summary>
        /// Handles the clear click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        protected void HandleClearClick(object sender, EventArgs e)
        {
            lbEvents.Items.Clear();
        }

        /// <summary>
        /// Handles the click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleClick(object sender, MarkerEventArgs e)
        {
            PrintEvent("Click", e);
        }

        /// <summary>
        /// Handles the clickable changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleClickableChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("ClickableChanged", e);
        }

        /// <summary>
        /// Handles the cursor changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleCursorChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("CursorChanged", e);
        }

        /// <summary>
        /// Handles the double click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleDoubleClick(object sender, MarkerEventArgs e)
        {
            PrintEvent("DoubleClick", e);
        }

        /// <summary>
        /// Handles the drag.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleDrag(object sender, MarkerEventArgs e)
        {
            PrintEvent("Drag", e);
        }

        /// <summary>
        /// Handles the drag end.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleDragEnd(object sender, MarkerEventArgs e)
        {
            PrintEvent("DragEnd", e);
        }

        /// <summary>
        /// Handles the draggable changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleDraggableChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("DraggableChanged", e);
        }

        /// <summary>
        /// Handles the drag start.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleDragStart(object sender, MarkerEventArgs e)
        {
            PrintEvent("DragStart", e);
        }

        /// <summary>
        /// Handles the flat changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleFlatChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("FlatChanged", e);
        }

        /// <summary>
        /// Handles the icon changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleIconChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("IconChanged", e);
        }

        /// <summary>
        /// Handles the mouse down.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleMouseDown(object sender, MarkerEventArgs e)
        {
            PrintEvent("MouseDown", e);
        }

        /// <summary>
        /// Handles the mouse out.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleMouseOut(object sender, MarkerEventArgs e)
        {
            PrintEvent("MouseOut", e);
        }

        /// <summary>
        /// Handles the mouse over.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleMouseOver(object sender, MarkerEventArgs e)
        {
            PrintEvent("MouseOver", e);
        }

        /// <summary>
        /// Handles the mouse up.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleMouseUp(object sender, MarkerEventArgs e)
        {
            PrintEvent("MouseUp", e);
        }

        /// <summary>
        /// Handles the position changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandlePositionChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("PositionChanged", e);
        }

        /// <summary>
        /// Handles the right click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleRightClick(object sender, MarkerEventArgs e)
        {
            PrintEvent("RightClick", e);
        }

        /// <summary>
        /// Handles the shadow changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleShadowChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("ShadowChanged", e);
        }

        /// <summary>
        /// Handles the shape changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleShapeChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("ShapeChanged", e);
        }

        /// <summary>
        /// Handles the title changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleTitleChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("TitleChanged", e);
        }

        /// <summary>
        /// Handles the visible changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleVisibleChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("VisibleChanged", e);
        }

        /// <summary>
        /// Handles the Z index changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void HandleZIndexChanged(object sender, MarkerEventArgs e)
        {
            PrintEvent("ZIndexChanged", e);
        }

        /// <summary>
        /// Prints the event.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="e">The <see cref="Velyo.Google.Map.UI.MarkerEventArgs"/> instance containing the event data.</param>
        protected void PrintEvent(string name, MarkerEventArgs e)
        {
            lbEvents.Items.Add(
                string.Format("{0} event was fired by marker [index: {1}] at position [lat: {2}, lng: {3}].",
                    name, e.Index, e.Position.Latitude, e.Position.Longitude));
        }
    }
}