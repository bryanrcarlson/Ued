namespace Ued.Core
{
    /// <summary>
    /// Enum of uint values that correspond to data quality
    /// See corn\quality.h
    /// </summary>
    public enum UedQualityCode : uint
    {
        observed_quality                        = 0,
        calculated_quality                      = 1,
        interpolated_quality                    = 2,
        other_real_quality                      = 3,    // This is used for ClimGen when calculating relative humidity from mean dew point.
                                                        // I may want to call this approximate_quality
                                                        // For precipitation trace values may be 0.0, very small or unmeasurable

        // Measure, calculated and interpolated are considered real data by ClimGen
        estimated_quality                       = 4,
        forecasted_quality                      = 5,
        generated_quality                       = 6,
        
        // reserved for future                             7

        derived_quality                         = 8,    // This is a place holder, it is the start of the composed variable codes
                                                        // Note that there are a few composed qualities that will never be used
                                                        // (I.e.   Measure from calculated, measured from interpolated , etc..

        default_quality                         = 0x3F,
        not_valid_quality                       = 0x80,         // (not inviolate)
                                                                // The following are range errors
        out_of_range_deprecated_quality         = 0x81,        // Becoming obsolete reserve for future use
        missing_quality                         = 0x82,
        out_of_range_warning_quality            = 0x83,
        out_of_range_low_warning_quality        = 0x84,
        out_of_range_high_warning_quality       = 0x85,
        out_of_range_pot_error_quality          = 0x86,
        out_of_range_pot_low_error_quality      = 0x87,
        out_of_range_pot_high_error_quality     = 0x88,
        out_of_range_error_quality              = 0x89,
        out_of_range_low_error_quality          = 0x8A,
        out_of_range_high_error_quality         = 0x8B,
        //           reserved for future range errors  0x8C- 0x8F
        unknown_quality = 0xBF
    };
}