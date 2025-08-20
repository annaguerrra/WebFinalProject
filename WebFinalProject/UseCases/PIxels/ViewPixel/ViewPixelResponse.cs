namespace WebFinalProject.UseCases.Pixels.ViewPixel;
using WebFinalProject.Models;

public record ViewPixelResponse(
    ICollection<Pixel> Pixels
);