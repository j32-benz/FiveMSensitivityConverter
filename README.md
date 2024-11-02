# FiveM Sensitivity Converter

This console application converts between `cm/360` and `Profile_MouseOnFootScale` for FiveM sensitivity, based on DPI.

## Features

- Convert `cm/360` to `Profile_MouseOnFootScale`
- Convert `Profile_MouseOnFootScale` to `cm/360`

## Usage

1. Run the application.
2. Select an option:
   - **1:** Convert `cm/360` to `Profile_MouseOnFootScale`
   - **2:** Convert `Profile_MouseOnFootScale` to `cm/360`
3. Enter required values:
   - For option 1: `cm/360` and `DPI`
   - For option 2: `Profile_MouseOnFootScale` and `DPI`
4. View the result.

## Formulae

- **To `Profile_MouseOnFootScale`**:  
  `Scale = (Constant / (DPI * cm/360)) - 60.25`

- **To `cm/360`**:  
  `cm/360 = Constant / (DPI * (Scale + 60.25))`

*Constant*: `1678106.125`

## Requirements

- .NET Framework
