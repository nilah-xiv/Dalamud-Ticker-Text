using System;
using System.Collections.Generic;

namespace Raffler.UI;

public static class LedFont
{
    public const int CharWidth = 5;
    public const int CharHeight = 7;

    public static readonly Dictionary<char, bool[,]> Glyphs = new()
    {
        ['A'] = FromLines(
            " 1 ",
            "1 1",
            "1 1",
            "111",
            "1 1",
            "1 1",
            "1 1"),
        ['B'] = FromLines(
            "11 ",
            "1 1",
            "11 ",
            "1 1",
            "1 1",
            "1 1",
            "11 "),
        ['C'] = FromLines(
            " 11",
            "1  ",
            "1  ",
            "1  ",
            "1  ",
            "1  ",
            " 11"),
        ['D'] = FromLines(
            "11 ",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "11 "),
        ['E'] = FromLines(
            "111",
            "1  ",
            "11 ",
            "1  ",
            "1  ",
            "1  ",
            "111"),
        ['F'] = FromLines(
            "111",
            "1  ",
            "11 ",
            "1  ",
            "1  ",
            "1  ",
            "1  "),
        ['G'] = FromLines(
            " 11",
            "1  ",
            "1  ",
            "1 1",
            "1 1",
            "1 1",
            " 11"),
        ['H'] = FromLines(
            "1 1",
            "1 1",
            "1 1",
            "111",
            "1 1",
            "1 1",
            "1 1"),
        ['I'] = FromLines(
            "111",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 ",
            "111"),
        ['J'] = FromLines(
            "111",
            "  1",
            "  1",
            "  1",
            "  1",
            "1 1",
            " 1 "),
        ['L'] = FromLines(
            "1  ",
            "1  ",
            "1  ",
            "1  ",
            "1  ",
            "1  ",
            "111"),
        ['N'] = FromLines(
            "1 1",
            "1 1",
            "11 1",
            "1 11",
            "1 1",
            "1 1",
            "1 1"),
        ['O'] = FromLines(
            "111",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "111"),
        ['R'] = FromLines(
            "11 ",
            "1 1",
            "1 1",
            "11 ",
            "1 1",
            "1 1",
            "1 1"),
        ['V'] = FromLines(
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            " 1 "),
        ['Y'] = FromLines(
            "1 1",
            "1 1",
            "1 1",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 "),
        [' '] = FromLines(
            "   ",
            "   ",
            "   ",
            "   ",
            "   ",
            "   ",
            "   "),
        [':'] = FromLines(
            "   ",
            " 1 ",
            "   ",
            "   ",
            " 1 ",
            "   ",
            "   "),
        ['|'] = FromLines(
            "   ",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 "),
        ['0'] = FromLines(
            "111",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "1 1",
            "111"),
        ['1'] = FromLines(
            " 1 ",
            "11 ",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 ",
            "111"),
        ['2'] = FromLines(
            "111",
            "  1",
            "  1",
            "111",
            "1  ",
            "1  ",
            "111"),
        ['3'] = FromLines(
            "111",
            "  1",
            "  1",
            "111",
            "  1",
            "  1",
            "111"),
        ['4'] = FromLines(
            "1 1",
            "1 1",
            "1 1",
            "111",
            "  1",
            "  1",
            "  1"),
        ['5'] = FromLines(
            "111",
            "1  ",
            "1  ",
            "111",
            "  1",
            "  1",
            "111"),
        ['6'] = FromLines(
            "111",
            "1  ",
            "1  ",
            "111",
            "1 1",
            "1 1",
            "111"),
        ['7'] = FromLines(
            "111",
            "  1",
            "  1",
            " 1 ",
            " 1 ",
            " 1 ",
            " 1 "),
        ['8'] = FromLines(
            "111",
            "1 1",
            "1 1",
            "111",
            "1 1",
            "1 1",
            "111"),
        ['9'] = FromLines(
            "111",
            "1 1",
            "1 1",
            "111",
            "  1",
            "  1",
            "111")
    };

    private static bool[,] FromLines(params string[] lines)
    {
        int h = lines.Length;
        int w = lines[0].Length;
        var data = new bool[h, w];
        for (int y = 0; y < h; y++)
        {
            for (int x = 0; x < w; x++)
                data[y, x] = lines[y][x] == '1';
        }
        return data;
    }
}