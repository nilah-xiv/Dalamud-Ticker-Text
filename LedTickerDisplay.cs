using System;
using System.Collections.Generic;
using System.Numerics;
using Dalamud.Interface;
using ImGuiNET;

namespace Raffler.UI;

public class LedTickerDisplay
{
    private float scrollOffset = 0f;
    private float scrollSpeed = 30f; // pixels per second
    private float dotSize = 6f;
    private float dotPadding = 1f;
    private float charPadding = 2f;
    private Vector3 color = new(0.2f, 1.0f, 0.2f); // Default green

    private string cachedMessage = "";
    private List<bool[,]> buffer = new();

    public void SetColor(Vector3 rgb) => color = rgb;

    public void SetMessage(string message)
    {
        if (message == cachedMessage) return;
        cachedMessage = message.ToUpperInvariant();
        BuildBuffer(cachedMessage);
    }

    private void BuildBuffer(string message)
    {
        buffer.Clear();
        foreach (var ch in message)
        {
            if (LedFont.Glyphs.TryGetValue(ch, out var glyph))
            {
                buffer.Add(glyph);
            }
        }
    }

    public void Update(float deltaTime)
    {
        scrollOffset += scrollSpeed * deltaTime;
        float totalWidth = GetTotalWidth();
        if (scrollOffset >= totalWidth)
            scrollOffset = 0f;
    }

    public void Draw(Vector2 position)
    {
        var drawList = ImGui.GetWindowDrawList();
        float xCursor = position.X - scrollOffset;
        float yCursor = position.Y;

        foreach (var glyph in buffer)
        {
            int rows = glyph.GetLength(0);
            int cols = glyph.GetLength(1);

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (!glyph[row, col]) continue;

                    float x = xCursor + (col * (dotSize + dotPadding));
                    float y = yCursor + (row * (dotSize + dotPadding));

                    drawList.AddCircleFilled(new Vector2(x, y), dotSize / 2f, ImGui.ColorConvertFloat4ToU32(new Vector4(color, 1f)));
                }
            }

            xCursor += (cols * (dotSize + dotPadding)) + charPadding;
        }
    }

    private float GetTotalWidth()
    {
        float total = 0f;
        foreach (var glyph in buffer)
        {
            int cols = glyph.GetLength(1);
            total += (cols * (dotSize + dotPadding)) + charPadding;
        }
        return total;
    }
}