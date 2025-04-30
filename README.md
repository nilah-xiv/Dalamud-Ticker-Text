# Dalamud-Ticker-Text

A simple, reusable ImGui-based LED-style ticker for Dalamud plugins. 
Displays scrolling dot-matrix text using circular "LEDs", perfect for stylish in-game UI elements.

## Features
- Smooth horizontal scrolling
- Customizable text, color, speed, and position
- 5x7 pixel font rendering with circle LED effects
- Easily embeddable into other Dalamud plugins

## Usage

### 1. Add the Ticker to Your Plugin
```csharp
private LedTickerDisplay ticker = new LedTickerDisplay();
```
### 2. Add the Ticker to Your Plugin
```csharp
ticker.SetText("WELCOME TO THE LED TICKER!");
ticker.Update(ImGui.GetIO().DeltaTime);
ticker.Draw(new Vector2(20, 500)); // adjust position
```
### 3. Optional Customization
```csharp
ticker.SetColor(new Vector3(1.0f, 0.4f, 0.4f)); // red tint
ticker.SetScrollSpeed(45f); // pixels per second
```
