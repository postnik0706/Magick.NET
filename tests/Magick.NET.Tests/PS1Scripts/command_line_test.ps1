# Convert Png to Tiff and set comment.
C:\image\magick.exe -comment "test" "..\Images\Magick.NET.icon.png" ".\Magick.NET.icon.tif"

# Get image information.
C:\image\magick.exe identify -verbose ".\Magick.NET.icon.tif"
