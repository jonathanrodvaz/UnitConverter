using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public class ConverterService
    {
        //Ponemos que el metodo es double porque puede devolvernos una gran cantidad de decimales. 
        public double ConvertMassUnit(MassEnum from, MassEnum to, double amount) 
        {
            double convertedValue = 0;

            switch (from)
                {
                case MassEnum.Miligram: 
                    {
                        switch(to) 
                        {
                            case MassEnum.Gram:
                                convertedValue = amount / 100;
                                break;
                            case MassEnum.Kilogram:
                                convertedValue = amount / 1000000;
                                break;
                            default:
                                break;
                        }
                    }
                        break;
                    case MassEnum.Gram:
                    {
                        switch (to)
                        {
                            case MassEnum.Miligram:
                                convertedValue = amount * 1000;
                                break;
                            case MassEnum.Kilogram:
                                convertedValue = amount / 1000;
                                break;
                            default:
                                break;
                        }

                    }
                        break;
                    case MassEnum.Kilogram:
                    {
                        switch (to)
                        {
                            case MassEnum.Gram:
                                convertedValue = amount * 1000;
                                break;
                            case MassEnum.Miligram:
                                convertedValue = amount * 1000000;
                                break;
                            default:
                                break;
                        }
                    }    
                    break;
                    default:
                        break;
            }



            return convertedValue;
        }

        public double ConvertTemperatureUnit(TemperatureEnum from, TemperatureEnum to, double amount)
        {
            double convertedValue = 0;

            switch (from)
            {
                case TemperatureEnum.Celsius:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Fahrenheit:
                                convertedValue = (amount * 1.8) + 32;
                                break;
                            case TemperatureEnum.Kelvin:
                                convertedValue = amount + 273.15;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TemperatureEnum.Fahrenheit:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Celsius:
                                convertedValue = (amount - 32) * 1.8;
                                break;
                                case TemperatureEnum.Kelvin:
                                convertedValue = (amount - 32) * 1.8 + 273.15;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case TemperatureEnum.Kelvin:
                    {
                        switch (to)
                        {
                            case TemperatureEnum.Celsius:
                                convertedValue = amount - 273.15;
                                break;
                            case TemperatureEnum.Fahrenheit:
                                convertedValue = (amount - 273.15) * 1.8 + 32;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }



            return convertedValue;
        }

        public double ConvertTimeUnit(TimeEnum from, TimeEnum to, double amount)
        {
            double convertedValue = 0;

            switch (from)
            {
                case TimeEnum.Miliseconds:
                    {
                        switch (to)
                        {
                            case TimeEnum.Seconds:
                                convertedValue = amount / 1000;
                                break;
                            case TimeEnum.Minutes:
                                convertedValue = amount / 60000;
                                break;
                                case TimeEnum.Hours:
                                convertedValue = amount / 3600000;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TimeEnum.Seconds:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                convertedValue = amount * 100;
                                break;
                            case TimeEnum.Minutes:
                                convertedValue = amount / 60;
                                break;
                            case TimeEnum.Hours:
                                convertedValue = amount / 3600;
                                break;
                            default:
                                break;
                        }

                    }
                    break;
                case TimeEnum.Minutes:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                convertedValue = amount * 60000;
                                break;
                            case TimeEnum.Seconds:
                                convertedValue = amount * 60;
                                break;
                            case TimeEnum.Hours:
                                convertedValue = amount / 60;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case TimeEnum.Hours:
                    {
                        switch (to)
                        {
                            case TimeEnum.Miliseconds:
                                convertedValue = amount * 3600000;
                                break;
                            case TimeEnum.Seconds:
                                convertedValue = amount * 3600;
                                break;
                            case TimeEnum.Minutes:
                                convertedValue = amount * 60;
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }



            return convertedValue;
        }
    }
}
