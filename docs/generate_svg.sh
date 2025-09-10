#!/usr/bin/env bash
# generate_svg.sh
# Usage: ./generate_svg.sh path/to/file.mmd

# Exit if no argument given
if [ -z "$1" ]; then
  echo "Usage: $0 path/to/file.mmd"
  exit 1
fi

INPUT_FILE="$1"

# Check that the input exists
if [ ! -f "$INPUT_FILE" ]; then
  echo "Error: file '$INPUT_FILE' not found."
  exit 1
fi

# Replace extension .mmd with .svg
OUTPUT_FILE="${INPUT_FILE%.mmd}.svg"

# Run mermaid-cli with no-sandbox config
mmdc -i "$INPUT_FILE" -o "$OUTPUT_FILE" --puppeteerConfigFile docs/puppeteer.config.json

if [ $? -eq 0 ]; then
  echo "✅ Generated: $OUTPUT_FILE"
else
  echo "❌ Failed to generate SVG"
  exit 1
fi
