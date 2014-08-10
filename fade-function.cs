public static double fade(double t) {
                                                        // Fade function as defined by Ken Perlin.  This eases coordinate values
                                                        // so that they will ease towards integral values.  This ends up smoothing
                                                        // the final output.
    return t * t * t * (t * (t * 6 - 15) + 10);         // 6t^5 - 15t^4 + 10t^3
}

public double perlin(double x, double y, double z) {
    // ...

    double u = fade(xf);
    double v = fade(yf);
    double w = fade(zf);

    // ...
}