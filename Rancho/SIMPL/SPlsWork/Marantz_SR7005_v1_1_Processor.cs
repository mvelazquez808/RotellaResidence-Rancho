using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace CrestronModule_MARANTZ_SR7005_V1_1_PROCESSOR
{
    public class CrestronModuleClass_MARANTZ_SR7005_V1_1_PROCESSOR : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput HD_RADIO_KEYPAD_BACKSPACE;
        Crestron.Logos.SplusObjects.DigitalInput HD_RADIO_KEYPAD_CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput HD_RADIO_KEYPAD_ENTER;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SIRIUS_KEYPAD;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SIRIUS_LOCK_KEYPAD;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> HD_RADIO_KEYPAD;
        Crestron.Logos.SplusObjects.AnalogInput HD_RADIO_BAND;
        Crestron.Logos.SplusObjects.AnalogInput MAIN_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_2_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput ZONE_3_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_L_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_R_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput CENTER_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SUBWOOFER_1_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SUBWOOFER_2_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SURROUND_L_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SURROUND_R_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SURROUND_BACK_L_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SURROUND_BACK_R_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput SURROUND_BACK_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_HEIGHT_L_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_HEIGHT_R_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_WIDE_L_VALUE;
        Crestron.Logos.SplusObjects.AnalogInput FRONT_WIDE_R_VALUE;
        Crestron.Logos.SplusObjects.StringInput NSE0_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE1_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE2_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE3_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE4_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE5_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE6_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE7_LINE;
        Crestron.Logos.SplusObjects.StringInput NSE8_LINE;
        Crestron.Logos.SplusObjects.AnalogOutput MAIN_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_2_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput ZONE_3_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_L_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_R_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput CENTER_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SUBWOOFER_1_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SUBWOOFER_2_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SURROUND_L_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SURROUND_R_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SURROUND_BACK_L_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SURROUND_BACK_R_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput SURROUND_BACK_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_HEIGHT_L_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_HEIGHT_R_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_WIDE_L_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.AnalogOutput FRONT_WIDE_R_VOLUME_TO_SCALE;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_STATION_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SIRIUS_LOCK_TEXT;
        Crestron.Logos.SplusObjects.StringOutput HD_RADIO_STATION_TEXT;
        Crestron.Logos.SplusObjects.StringOutput TO_DEVICE;
        Crestron.Logos.SplusObjects.StringOutput MAIN_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE_2_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput ZONE_3_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_L_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_R_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput CENTER_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SUBWOOFER_1_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SUBWOOFER_2_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SURROUND_L_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SURROUND_R_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SURROUND_BACK_L_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SURROUND_BACK_R_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput SURROUND_BACK_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_HEIGHT_L_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_HEIGHT_R_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_WIDE_L_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput FRONT_WIDE_R_VOLUME_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_1_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_2_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_3_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_4_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_5_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_6_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_7_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_8_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DISPLAY_LINE_9_TEXT;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_2_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_3_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_4_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_5_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_6_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_7_IS_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput DISPLAY_LINE_8_IS_ACTIVE;
        ushort A = 0;
        CrestronString SSIRIUSSTATIONTEXTTEMP;
        CrestronString SSIRIUSLOCKTEXTTEMP;
        CrestronString SHDRADIOSTATIONTEXTTEMP;
        CrestronString SHDRADIOSTATIONTEXTTEMP2;
        CrestronString SDISPLAYLINE1TEMP;
        CrestronString SDISPLAYLINE2TEMP;
        CrestronString SDISPLAYLINE3TEMP;
        CrestronString SDISPLAYLINE4TEMP;
        CrestronString SDISPLAYLINE5TEMP;
        CrestronString SDISPLAYLINE6TEMP;
        CrestronString SDISPLAYLINE7TEMP;
        CrestronString SDISPLAYLINE8TEMP;
        CrestronString SDISPLAYLINE9TEMP;
        ushort INSE0 = 0;
        ushort INSE1 = 0;
        ushort INSE2 = 0;
        ushort INSE3 = 0;
        ushort INSE4 = 0;
        ushort INSE5 = 0;
        ushort INSE6 = 0;
        ushort INSE7 = 0;
        ushort INSE8 = 0;
        CrestronString SDISPLAYLINE1OUT;
        CrestronString SDISPLAYLINE2OUT;
        CrestronString SDISPLAYLINE3OUT;
        CrestronString SDISPLAYLINE4OUT;
        CrestronString SDISPLAYLINE5OUT;
        CrestronString SDISPLAYLINE6OUT;
        CrestronString SDISPLAYLINE7OUT;
        CrestronString SDISPLAYLINE8OUT;
        CrestronString SDISPLAYLINE9OUT;
        object SIRIUS_KEYPAD_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 267;
                switch ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ))
                
                    { 
                    case 1 : 
                    
                        { 
                        __context__.SourceCodeLine = 271;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 272;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 273;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}1", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 274;
                        break ; 
                        } 
                    
                    goto case 2 ;
                    case 2 : 
                    
                        { 
                        __context__.SourceCodeLine = 278;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 279;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 280;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}2", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 281;
                        break ; 
                        } 
                    
                    goto case 3 ;
                    case 3 : 
                    
                        { 
                        __context__.SourceCodeLine = 285;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 286;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 287;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}3", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 288;
                        break ; 
                        } 
                    
                    goto case 4 ;
                    case 4 : 
                    
                        { 
                        __context__.SourceCodeLine = 292;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 293;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 294;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}4", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 295;
                        break ; 
                        } 
                    
                    goto case 5 ;
                    case 5 : 
                    
                        { 
                        __context__.SourceCodeLine = 299;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 300;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 301;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}5", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 302;
                        break ; 
                        } 
                    
                    goto case 6 ;
                    case 6 : 
                    
                        { 
                        __context__.SourceCodeLine = 306;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 307;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 308;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}6", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 309;
                        break ; 
                        } 
                    
                    goto case 7 ;
                    case 7 : 
                    
                        { 
                        __context__.SourceCodeLine = 313;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 314;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 315;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}7", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 316;
                        break ; 
                        } 
                    
                    goto case 8 ;
                    case 8 : 
                    
                        { 
                        __context__.SourceCodeLine = 320;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 321;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 322;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}8", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 323;
                        break ; 
                        } 
                    
                    goto case 9 ;
                    case 9 : 
                    
                        { 
                        __context__.SourceCodeLine = 327;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 328;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 329;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}9", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 330;
                        break ; 
                        } 
                    
                    goto case 10 ;
                    case 10 : 
                    
                        { 
                        __context__.SourceCodeLine = 334;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) == 3))  ) ) 
                            {
                            __context__.SourceCodeLine = 335;
                            Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                            }
                        
                        __context__.SourceCodeLine = 336;
                        MakeString ( SSIRIUSSTATIONTEXTTEMP , "{0}0", SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 337;
                        break ; 
                        } 
                    
                    goto case 11 ;
                    case 11 : 
                    
                        { 
                        __context__.SourceCodeLine = 341;
                        SSIRIUSSTATIONTEXTTEMP  .UpdateValue ( Functions.Left ( SSIRIUSSTATIONTEXTTEMP ,  (int) ( (Functions.Length( SSIRIUSSTATIONTEXTTEMP ) - 1) ) )  ) ; 
                        __context__.SourceCodeLine = 342;
                        break ; 
                        } 
                    
                    goto case 12 ;
                    case 12 : 
                    
                        { 
                        __context__.SourceCodeLine = 346;
                        Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
                        __context__.SourceCodeLine = 347;
                        break ; 
                        } 
                    
                    goto case 13 ;
                    case 13 : 
                    
                        { 
                        __context__.SourceCodeLine = 351;
                        MakeString ( TO_DEVICE , "TFST{0:d3}\r", (short)Functions.Atoi( SSIRIUSSTATIONTEXTTEMP )) ; 
                        __context__.SourceCodeLine = 352;
                        break ; 
                        } 
                    
                    break;
                    } 
                    
                
                __context__.SourceCodeLine = 355;
                SIRIUS_STATION_TEXT  .UpdateValue ( SSIRIUSSTATIONTEXTTEMP  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SIRIUS_LOCK_KEYPAD_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 360;
            switch ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ))
            
                { 
                case 1 : 
                
                    { 
                    __context__.SourceCodeLine = 364;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 365;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 366;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}1", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 367;
                    break ; 
                    } 
                
                goto case 2 ;
                case 2 : 
                
                    { 
                    __context__.SourceCodeLine = 371;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 372;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 373;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}2", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 374;
                    break ; 
                    } 
                
                goto case 3 ;
                case 3 : 
                
                    { 
                    __context__.SourceCodeLine = 378;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 379;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 380;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}3", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 381;
                    break ; 
                    } 
                
                goto case 4 ;
                case 4 : 
                
                    { 
                    __context__.SourceCodeLine = 385;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 386;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 387;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}4", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 388;
                    break ; 
                    } 
                
                goto case 5 ;
                case 5 : 
                
                    { 
                    __context__.SourceCodeLine = 392;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 393;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 394;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}5", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 395;
                    break ; 
                    } 
                
                goto case 6 ;
                case 6 : 
                
                    { 
                    __context__.SourceCodeLine = 399;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 400;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 401;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}6", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 402;
                    break ; 
                    } 
                
                goto case 7 ;
                case 7 : 
                
                    { 
                    __context__.SourceCodeLine = 406;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 407;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 408;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}7", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 409;
                    break ; 
                    } 
                
                goto case 8 ;
                case 8 : 
                
                    { 
                    __context__.SourceCodeLine = 413;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 414;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 415;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}8", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 416;
                    break ; 
                    } 
                
                goto case 9 ;
                case 9 : 
                
                    { 
                    __context__.SourceCodeLine = 420;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 421;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 422;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}9", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 423;
                    break ; 
                    } 
                
                goto case 10 ;
                case 10 : 
                
                    { 
                    __context__.SourceCodeLine = 427;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SSIRIUSLOCKTEXTTEMP ) == 4))  ) ) 
                        {
                        __context__.SourceCodeLine = 428;
                        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                        }
                    
                    __context__.SourceCodeLine = 429;
                    MakeString ( SSIRIUSLOCKTEXTTEMP , "{0}0", SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 430;
                    break ; 
                    } 
                
                goto case 11 ;
                case 11 : 
                
                    { 
                    __context__.SourceCodeLine = 434;
                    SSIRIUSLOCKTEXTTEMP  .UpdateValue ( Functions.Left ( SSIRIUSLOCKTEXTTEMP ,  (int) ( (Functions.Length( SSIRIUSLOCKTEXTTEMP ) - 1) ) )  ) ; 
                    __context__.SourceCodeLine = 435;
                    break ; 
                    } 
                
                goto case 12 ;
                case 12 : 
                
                    { 
                    __context__.SourceCodeLine = 439;
                    Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 440;
                    break ; 
                    } 
                
                goto case 13 ;
                case 13 : 
                
                    { 
                    __context__.SourceCodeLine = 444;
                    MakeString ( TO_DEVICE , "TFSTPL{0:d4}\r", (short)Functions.Atoi( SSIRIUSLOCKTEXTTEMP )) ; 
                    __context__.SourceCodeLine = 445;
                    Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
                    __context__.SourceCodeLine = 446;
                    SIRIUS_LOCK_TEXT  .UpdateValue ( SSIRIUSLOCKTEXTTEMP  ) ; 
                    __context__.SourceCodeLine = 447;
                    break ; 
                    } 
                
                break;
                } 
                
            
            __context__.SourceCodeLine = 450;
            SIRIUS_LOCK_TEXT  .UpdateValue ( SSIRIUSLOCKTEXTTEMP  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object HD_RADIO_KEYPAD_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 455;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Length( SHDRADIOSTATIONTEXTTEMP ) == 4))  ) ) 
            {
            __context__.SourceCodeLine = 456;
            Functions.ClearBuffer ( SHDRADIOSTATIONTEXTTEMP ) ; 
            }
        
        __context__.SourceCodeLine = 458;
        switch ((int)Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ))
        
            { 
            case 1 : 
            
                { 
                __context__.SourceCodeLine = 462;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}1", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 463;
                break ; 
                } 
            
            goto case 2 ;
            case 2 : 
            
                { 
                __context__.SourceCodeLine = 467;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}2", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 468;
                break ; 
                } 
            
            goto case 3 ;
            case 3 : 
            
                { 
                __context__.SourceCodeLine = 472;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}3", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 473;
                break ; 
                } 
            
            goto case 4 ;
            case 4 : 
            
                { 
                __context__.SourceCodeLine = 477;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}4", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 478;
                break ; 
                } 
            
            goto case 5 ;
            case 5 : 
            
                { 
                __context__.SourceCodeLine = 482;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}5", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 483;
                break ; 
                } 
            
            goto case 6 ;
            case 6 : 
            
                { 
                __context__.SourceCodeLine = 487;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}6", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 488;
                break ; 
                } 
            
            goto case 7 ;
            case 7 : 
            
                { 
                __context__.SourceCodeLine = 492;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}7", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 493;
                break ; 
                } 
            
            goto case 8 ;
            case 8 : 
            
                { 
                __context__.SourceCodeLine = 497;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}8", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 498;
                break ; 
                } 
            
            goto case 9 ;
            case 9 : 
            
                { 
                __context__.SourceCodeLine = 502;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}9", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 503;
                break ; 
                } 
            
            goto case 10 ;
            case 10 : 
            
                { 
                __context__.SourceCodeLine = 507;
                MakeString ( SHDRADIOSTATIONTEXTTEMP , "{0}0", SHDRADIOSTATIONTEXTTEMP ) ; 
                __context__.SourceCodeLine = 508;
                break ; 
                } 
            
            break;
            } 
            
        
        __context__.SourceCodeLine = 512;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HD_RADIO_BAND  .UshortValue == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 514;
            Functions.ClearBuffer ( SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 515;
            SetString ( "." , (int)4, SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 516;
            SetString ( Functions.Right ( SHDRADIOSTATIONTEXTTEMP ,  (int) ( 1 ) ) , (int)5, SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 517;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SHDRADIOSTATIONTEXTTEMP ) > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 518;
                SetString ( Functions.Left ( SHDRADIOSTATIONTEXTTEMP ,  (int) ( (Functions.Length( SHDRADIOSTATIONTEXTTEMP ) - 1) ) ) , (int)(5 - Functions.Length( SHDRADIOSTATIONTEXTTEMP )), SHDRADIOSTATIONTEXTTEMP2 ) ; 
                }
            
            __context__.SourceCodeLine = 519;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "{0} mHZ FM", SHDRADIOSTATIONTEXTTEMP2 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 523;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "{0} kHZ AM", SHDRADIOSTATIONTEXTTEMP ) ; 
            } 
        
        __context__.SourceCodeLine = 526;
        HD_RADIO_STATION_TEXT  .UpdateValue ( SHDRADIOSTATIONTEXTTEMP2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HD_RADIO_BAND_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 532;
        Functions.ClearBuffer ( SHDRADIOSTATIONTEXTTEMP ) ; 
        __context__.SourceCodeLine = 533;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HD_RADIO_BAND  .UshortValue == 1))  ) ) 
            {
            __context__.SourceCodeLine = 534;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , ".  mHZ FM") ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 536;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "kHZ AM") ; 
            }
        
        __context__.SourceCodeLine = 538;
        HD_RADIO_STATION_TEXT  .UpdateValue ( SHDRADIOSTATIONTEXTTEMP2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HD_RADIO_KEYPAD_BACKSPACE_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 544;
        SHDRADIOSTATIONTEXTTEMP  .UpdateValue ( Functions.Left ( SHDRADIOSTATIONTEXTTEMP ,  (int) ( (Functions.Length( SHDRADIOSTATIONTEXTTEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 545;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HD_RADIO_BAND  .UshortValue == 1))  ) ) 
            { 
            __context__.SourceCodeLine = 547;
            Functions.ClearBuffer ( SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 548;
            SetString ( "." , (int)4, SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 549;
            SetString ( Functions.Right ( SHDRADIOSTATIONTEXTTEMP ,  (int) ( 1 ) ) , (int)5, SHDRADIOSTATIONTEXTTEMP2 ) ; 
            __context__.SourceCodeLine = 550;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( SHDRADIOSTATIONTEXTTEMP ) > 1 ))  ) ) 
                {
                __context__.SourceCodeLine = 551;
                SetString ( Functions.Left ( SHDRADIOSTATIONTEXTTEMP ,  (int) ( (Functions.Length( SHDRADIOSTATIONTEXTTEMP ) - 1) ) ) , (int)(5 - Functions.Length( SHDRADIOSTATIONTEXTTEMP )), SHDRADIOSTATIONTEXTTEMP2 ) ; 
                }
            
            __context__.SourceCodeLine = 552;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "{0} mHZ FM", SHDRADIOSTATIONTEXTTEMP2 ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 556;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "{0} kHZ AM", SHDRADIOSTATIONTEXTTEMP ) ; 
            } 
        
        __context__.SourceCodeLine = 559;
        HD_RADIO_STATION_TEXT  .UpdateValue ( SHDRADIOSTATIONTEXTTEMP2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HD_RADIO_KEYPAD_CLEAR_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 564;
        Functions.ClearBuffer ( SHDRADIOSTATIONTEXTTEMP ) ; 
        __context__.SourceCodeLine = 565;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HD_RADIO_BAND  .UshortValue == 1))  ) ) 
            {
            __context__.SourceCodeLine = 566;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , ".  mHZ FM") ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 568;
            MakeString ( SHDRADIOSTATIONTEXTTEMP2 , "kHZ AM") ; 
            }
        
        __context__.SourceCodeLine = 570;
        HD_RADIO_STATION_TEXT  .UpdateValue ( SHDRADIOSTATIONTEXTTEMP2  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HD_RADIO_KEYPAD_ENTER_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 575;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (HD_RADIO_BAND  .UshortValue == 1))  ) ) 
            {
            __context__.SourceCodeLine = 576;
            MakeString ( TO_DEVICE , "TFHD{0:d5}0\r", (short)Functions.Atoi( SHDRADIOSTATIONTEXTTEMP )) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 578;
            MakeString ( TO_DEVICE , "TFHD{0:d4}00\r", (short)Functions.Atoi( SHDRADIOSTATIONTEXTTEMP )) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MAIN_VALUE_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 584;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAIN_VALUE  .UshortValue == 990))  ) ) 
            { 
            __context__.SourceCodeLine = 586;
            MAIN_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 587;
            MAIN_VOLUME_TEXT  .UpdateValue ( "---.-dB"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 589;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MAIN_VALUE  .UshortValue == 995))  ) ) 
                { 
                __context__.SourceCodeLine = 591;
                MAIN_VOLUME_TO_SCALE  .Value = (ushort) ( 5 ) ; 
                __context__.SourceCodeLine = 592;
                MAIN_VOLUME_TEXT  .UpdateValue ( "-80.5dB"  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 596;
                MAIN_VOLUME_TO_SCALE  .Value = (ushort) ( (MAIN_VALUE  .UshortValue + 10) ) ; 
                __context__.SourceCodeLine = 597;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MAIN_VALUE  .UshortValue >= 800 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 599;
                    MakeString ( MAIN_VOLUME_TEXT , "{0:d}.{1:d}dB", (short)((MAIN_VALUE  .UshortValue - 800) / 10), (short)Mod( (MAIN_VALUE  .UshortValue - 800) , 10 )) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 602;
                    MakeString ( MAIN_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((800 - MAIN_VALUE  .UshortValue) / 10), (short)Mod( (800 - MAIN_VALUE  .UshortValue) , 10 )) ; 
                    }
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_2_VALUE_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 608;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE_2_VALUE  .UshortValue == 990))  ) ) 
            { 
            __context__.SourceCodeLine = 610;
            ZONE_2_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 611;
            ZONE_2_VOLUME_TEXT  .UpdateValue ( "---dB"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 613;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ZONE_2_VALUE  .UshortValue >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ZONE_2_VALUE  .UshortValue < 990 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 615;
                ZONE_2_VOLUME_TO_SCALE  .Value = (ushort) ( ZONE_2_VALUE  .UshortValue ) ; 
                __context__.SourceCodeLine = 616;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ZONE_2_VALUE  .UshortValue >= 800 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 618;
                    MakeString ( ZONE_2_VOLUME_TEXT , "{0:d}dB", (short)((ZONE_2_VALUE  .UshortValue - 800) / 10)) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 621;
                    MakeString ( ZONE_2_VOLUME_TEXT , "-{0:d}dB", (short)((800 - ZONE_2_VALUE  .UshortValue) / 10)) ; 
                    }
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ZONE_3_VALUE_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 627;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE_3_VALUE  .UshortValue == 990))  ) ) 
            { 
            __context__.SourceCodeLine = 629;
            ZONE_3_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 630;
            ZONE_3_VOLUME_TEXT  .UpdateValue ( "---dB"  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 632;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( ZONE_3_VALUE  .UshortValue >= 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( ZONE_3_VALUE  .UshortValue < 990 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 634;
                ZONE_3_VOLUME_TO_SCALE  .Value = (ushort) ( ZONE_3_VALUE  .UshortValue ) ; 
                __context__.SourceCodeLine = 635;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ZONE_3_VALUE  .UshortValue >= 800 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 637;
                    MakeString ( ZONE_3_VOLUME_TEXT , "{0:d}dB", (short)((ZONE_3_VALUE  .UshortValue - 800) / 10)) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 640;
                    MakeString ( ZONE_3_VOLUME_TEXT , "-{0:d}dB", (short)((800 - ZONE_3_VALUE  .UshortValue) / 10)) ; 
                    }
                
                } 
            
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_L_VALUE_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 646;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_L_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 648;
            FRONT_L_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 649;
            FRONT_L_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 653;
            FRONT_L_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_L_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 654;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_L_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 656;
                MakeString ( FRONT_L_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_L_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_L_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 659;
                MakeString ( FRONT_L_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_L_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_L_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_R_VALUE_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 665;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_R_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 667;
            FRONT_R_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 668;
            FRONT_R_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 672;
            FRONT_R_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_R_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 673;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_R_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 675;
                MakeString ( FRONT_R_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_R_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_R_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 678;
                MakeString ( FRONT_R_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_R_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_R_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CENTER_VALUE_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 684;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CENTER_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 686;
            CENTER_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 687;
            CENTER_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 691;
            CENTER_VOLUME_TO_SCALE  .Value = (ushort) ( (CENTER_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 692;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CENTER_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 694;
                MakeString ( CENTER_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((CENTER_VALUE  .UshortValue - 500) / 10), (short)Mod( (CENTER_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 697;
                MakeString ( CENTER_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - CENTER_VALUE  .UshortValue) / 10), (short)Mod( (500 - CENTER_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBWOOFER_1_VALUE_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 703;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SUBWOOFER_1_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 705;
            SUBWOOFER_1_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 706;
            SUBWOOFER_1_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 710;
            SUBWOOFER_1_VOLUME_TO_SCALE  .Value = (ushort) ( (SUBWOOFER_1_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 711;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SUBWOOFER_1_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 713;
                MakeString ( SUBWOOFER_1_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SUBWOOFER_1_VALUE  .UshortValue - 500) / 10), (short)Mod( (SUBWOOFER_1_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 716;
                MakeString ( SUBWOOFER_1_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SUBWOOFER_1_VALUE  .UshortValue) / 10), (short)Mod( (500 - SUBWOOFER_1_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SUBWOOFER_2_VALUE_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 722;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SUBWOOFER_2_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 724;
            SUBWOOFER_2_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 725;
            SUBWOOFER_2_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 729;
            SUBWOOFER_2_VOLUME_TO_SCALE  .Value = (ushort) ( (SUBWOOFER_2_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 730;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SUBWOOFER_2_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 732;
                MakeString ( SUBWOOFER_2_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SUBWOOFER_2_VALUE  .UshortValue - 500) / 10), (short)Mod( (SUBWOOFER_2_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 735;
                MakeString ( SUBWOOFER_2_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SUBWOOFER_2_VALUE  .UshortValue) / 10), (short)Mod( (500 - SUBWOOFER_2_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUND_L_VALUE_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 741;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SURROUND_L_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 743;
            SURROUND_L_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 744;
            SURROUND_L_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 748;
            SURROUND_L_VOLUME_TO_SCALE  .Value = (ushort) ( (SURROUND_L_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 749;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SURROUND_L_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 751;
                MakeString ( SURROUND_L_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SURROUND_L_VALUE  .UshortValue - 500) / 10), (short)Mod( (SURROUND_L_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 754;
                MakeString ( SURROUND_L_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SURROUND_L_VALUE  .UshortValue) / 10), (short)Mod( (500 - SURROUND_L_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUND_R_VALUE_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 760;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SURROUND_R_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 762;
            SURROUND_R_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 763;
            SURROUND_R_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 767;
            SURROUND_R_VOLUME_TO_SCALE  .Value = (ushort) ( (SURROUND_R_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 768;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SURROUND_R_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 770;
                MakeString ( SURROUND_R_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SURROUND_R_VALUE  .UshortValue - 500) / 10), (short)Mod( (SURROUND_R_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 773;
                MakeString ( SURROUND_R_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SURROUND_R_VALUE  .UshortValue) / 10), (short)Mod( (500 - SURROUND_R_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUND_BACK_L_VALUE_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 779;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SURROUND_BACK_L_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 781;
            SURROUND_BACK_L_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 782;
            SURROUND_BACK_L_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 786;
            SURROUND_BACK_L_VOLUME_TO_SCALE  .Value = (ushort) ( (SURROUND_BACK_L_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 787;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SURROUND_BACK_L_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 789;
                MakeString ( SURROUND_BACK_L_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SURROUND_BACK_L_VALUE  .UshortValue - 500) / 10), (short)Mod( (SURROUND_BACK_L_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 792;
                MakeString ( SURROUND_BACK_L_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SURROUND_BACK_L_VALUE  .UshortValue) / 10), (short)Mod( (500 - SURROUND_BACK_L_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUND_BACK_R_VALUE_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 798;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SURROUND_BACK_R_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 800;
            SURROUND_BACK_R_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 801;
            SURROUND_BACK_R_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 805;
            SURROUND_BACK_R_VOLUME_TO_SCALE  .Value = (ushort) ( (SURROUND_BACK_R_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 806;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SURROUND_BACK_R_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 808;
                MakeString ( SURROUND_BACK_R_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SURROUND_BACK_R_VALUE  .UshortValue - 500) / 10), (short)Mod( (SURROUND_BACK_R_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 811;
                MakeString ( SURROUND_BACK_R_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SURROUND_BACK_R_VALUE  .UshortValue) / 10), (short)Mod( (500 - SURROUND_BACK_R_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SURROUND_BACK_VALUE_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 817;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SURROUND_BACK_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 819;
            SURROUND_BACK_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 820;
            SURROUND_BACK_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 824;
            SURROUND_BACK_VOLUME_TO_SCALE  .Value = (ushort) ( (SURROUND_BACK_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 825;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( SURROUND_BACK_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 827;
                MakeString ( SURROUND_BACK_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((SURROUND_BACK_VALUE  .UshortValue - 500) / 10), (short)Mod( (SURROUND_BACK_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 830;
                MakeString ( SURROUND_BACK_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - SURROUND_BACK_VALUE  .UshortValue) / 10), (short)Mod( (500 - SURROUND_BACK_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_HEIGHT_L_VALUE_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 836;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_HEIGHT_L_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 838;
            FRONT_HEIGHT_L_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 839;
            FRONT_HEIGHT_L_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 843;
            FRONT_HEIGHT_L_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_HEIGHT_L_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 844;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_HEIGHT_L_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 846;
                MakeString ( FRONT_HEIGHT_L_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_HEIGHT_L_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_HEIGHT_L_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 849;
                MakeString ( FRONT_HEIGHT_L_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_HEIGHT_L_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_HEIGHT_L_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_HEIGHT_R_VALUE_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 855;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_HEIGHT_R_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 857;
            FRONT_HEIGHT_R_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 858;
            FRONT_HEIGHT_R_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 862;
            FRONT_HEIGHT_R_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_HEIGHT_R_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 863;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_HEIGHT_R_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 865;
                MakeString ( FRONT_HEIGHT_R_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_HEIGHT_R_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_HEIGHT_R_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 868;
                MakeString ( FRONT_HEIGHT_R_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_HEIGHT_R_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_HEIGHT_R_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_WIDE_L_VALUE_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 874;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_WIDE_L_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 876;
            FRONT_WIDE_L_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 877;
            FRONT_WIDE_L_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 881;
            FRONT_WIDE_L_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_WIDE_L_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 882;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_WIDE_L_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 884;
                MakeString ( FRONT_WIDE_L_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_WIDE_L_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_WIDE_L_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 887;
                MakeString ( FRONT_WIDE_L_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_WIDE_L_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_WIDE_L_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object FRONT_WIDE_R_VALUE_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 893;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (FRONT_WIDE_R_VALUE  .UshortValue == 000))  ) ) 
            { 
            __context__.SourceCodeLine = 895;
            FRONT_WIDE_R_VOLUME_TO_SCALE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 896;
            FRONT_WIDE_R_VOLUME_TEXT  .UpdateValue ( "OFF"  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 900;
            FRONT_WIDE_R_VOLUME_TO_SCALE  .Value = (ushort) ( (FRONT_WIDE_R_VALUE  .UshortValue - 380) ) ; 
            __context__.SourceCodeLine = 901;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FRONT_WIDE_R_VALUE  .UshortValue >= 500 ))  ) ) 
                { 
                __context__.SourceCodeLine = 903;
                MakeString ( FRONT_WIDE_R_VOLUME_TEXT , "+{0:d}.{1:d}dB", (short)((FRONT_WIDE_R_VALUE  .UshortValue - 500) / 10), (short)Mod( (FRONT_WIDE_R_VALUE  .UshortValue - 500) , 10 )) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 906;
                MakeString ( FRONT_WIDE_R_VOLUME_TEXT , "-{0:d}.{1:d}dB", (short)((500 - FRONT_WIDE_R_VALUE  .UshortValue) / 10), (short)Mod( (500 - FRONT_WIDE_R_VALUE  .UshortValue) , 10 )) ; 
                }
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE0_LINE_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 912;
        SDISPLAYLINE1TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE0_LINE )  ) ; 
        __context__.SourceCodeLine = 913;
        SDISPLAYLINE1TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE1TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE1TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 914;
        Functions.ClearBuffer ( SDISPLAYLINE1OUT ) ; 
        __context__.SourceCodeLine = 915;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE1TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE0  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE0  >= __FN_FORSTART_VAL__1) && (INSE0  <= __FN_FOREND_VAL__1) ) : ( (INSE0  <= __FN_FORSTART_VAL__1) && (INSE0  >= __FN_FOREND_VAL__1) ) ; INSE0  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 917;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE1TEMP , (int)( INSE0 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 918;
                SDISPLAYLINE1OUT  .UpdateValue ( SDISPLAYLINE1OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE1TEMP , (int)( INSE0 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 915;
            } 
        
        __context__.SourceCodeLine = 920;
        DISPLAY_LINE_1_TEXT  .UpdateValue ( SDISPLAYLINE1OUT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE1_LINE_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 925;
        SDISPLAYLINE2TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE1_LINE )  ) ; 
        __context__.SourceCodeLine = 926;
        SDISPLAYLINE2TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE2TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE2TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 927;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE2TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 928;
            DISPLAY_LINE_2_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 930;
            DISPLAY_LINE_2_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 931;
        Functions.ClearBuffer ( SDISPLAYLINE2OUT ) ; 
        __context__.SourceCodeLine = 932;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE2TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE1  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE1  >= __FN_FORSTART_VAL__1) && (INSE1  <= __FN_FOREND_VAL__1) ) : ( (INSE1  <= __FN_FORSTART_VAL__1) && (INSE1  >= __FN_FOREND_VAL__1) ) ; INSE1  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 934;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE2TEMP , (int)( INSE1 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 935;
                SDISPLAYLINE2OUT  .UpdateValue ( SDISPLAYLINE2OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE2TEMP , (int)( INSE1 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 932;
            } 
        
        __context__.SourceCodeLine = 937;
        DISPLAY_LINE_2_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE2OUT ,  (int) ( (Functions.Length( SDISPLAYLINE2OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE2_LINE_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 943;
        SDISPLAYLINE3TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE2_LINE )  ) ; 
        __context__.SourceCodeLine = 944;
        SDISPLAYLINE3TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE3TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE3TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 945;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE3TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 946;
            DISPLAY_LINE_3_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 948;
            DISPLAY_LINE_3_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 949;
        Functions.ClearBuffer ( SDISPLAYLINE3OUT ) ; 
        __context__.SourceCodeLine = 950;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE3TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE2  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE2  >= __FN_FORSTART_VAL__1) && (INSE2  <= __FN_FOREND_VAL__1) ) : ( (INSE2  <= __FN_FORSTART_VAL__1) && (INSE2  >= __FN_FOREND_VAL__1) ) ; INSE2  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 952;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE3TEMP , (int)( INSE2 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 953;
                SDISPLAYLINE3OUT  .UpdateValue ( SDISPLAYLINE3OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE3TEMP , (int)( INSE2 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 950;
            } 
        
        __context__.SourceCodeLine = 955;
        DISPLAY_LINE_3_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE3OUT ,  (int) ( (Functions.Length( SDISPLAYLINE3OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE3_LINE_OnChange_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 961;
        SDISPLAYLINE4TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE3_LINE )  ) ; 
        __context__.SourceCodeLine = 962;
        SDISPLAYLINE4TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE4TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE4TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 963;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE4TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 964;
            DISPLAY_LINE_4_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 966;
            DISPLAY_LINE_4_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 967;
        Functions.ClearBuffer ( SDISPLAYLINE4OUT ) ; 
        __context__.SourceCodeLine = 968;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE4TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE3  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE3  >= __FN_FORSTART_VAL__1) && (INSE3  <= __FN_FOREND_VAL__1) ) : ( (INSE3  <= __FN_FORSTART_VAL__1) && (INSE3  >= __FN_FOREND_VAL__1) ) ; INSE3  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 970;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE4TEMP , (int)( INSE3 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 971;
                SDISPLAYLINE4OUT  .UpdateValue ( SDISPLAYLINE4OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE4TEMP , (int)( INSE3 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 968;
            } 
        
        __context__.SourceCodeLine = 973;
        DISPLAY_LINE_4_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE4OUT ,  (int) ( (Functions.Length( SDISPLAYLINE4OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE4_LINE_OnChange_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 979;
        SDISPLAYLINE5TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE4_LINE )  ) ; 
        __context__.SourceCodeLine = 980;
        SDISPLAYLINE5TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE5TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE5TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 981;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE5TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 982;
            DISPLAY_LINE_5_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 984;
            DISPLAY_LINE_5_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 985;
        Functions.ClearBuffer ( SDISPLAYLINE5OUT ) ; 
        __context__.SourceCodeLine = 986;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE5TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE4  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE4  >= __FN_FORSTART_VAL__1) && (INSE4  <= __FN_FOREND_VAL__1) ) : ( (INSE4  <= __FN_FORSTART_VAL__1) && (INSE4  >= __FN_FOREND_VAL__1) ) ; INSE4  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 988;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE5TEMP , (int)( INSE4 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 989;
                SDISPLAYLINE5OUT  .UpdateValue ( SDISPLAYLINE5OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE5TEMP , (int)( INSE4 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 986;
            } 
        
        __context__.SourceCodeLine = 991;
        DISPLAY_LINE_5_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE5OUT ,  (int) ( (Functions.Length( SDISPLAYLINE5OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE5_LINE_OnChange_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 997;
        SDISPLAYLINE6TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE5_LINE )  ) ; 
        __context__.SourceCodeLine = 998;
        SDISPLAYLINE6TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE6TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE6TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 999;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE6TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1000;
            DISPLAY_LINE_6_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1002;
            DISPLAY_LINE_6_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1003;
        Functions.ClearBuffer ( SDISPLAYLINE6OUT ) ; 
        __context__.SourceCodeLine = 1004;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE6TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE5  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE5  >= __FN_FORSTART_VAL__1) && (INSE5  <= __FN_FOREND_VAL__1) ) : ( (INSE5  <= __FN_FORSTART_VAL__1) && (INSE5  >= __FN_FOREND_VAL__1) ) ; INSE5  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1006;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE6TEMP , (int)( INSE5 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 1007;
                SDISPLAYLINE6OUT  .UpdateValue ( SDISPLAYLINE6OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE6TEMP , (int)( INSE5 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 1004;
            } 
        
        __context__.SourceCodeLine = 1009;
        DISPLAY_LINE_6_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE6OUT ,  (int) ( (Functions.Length( SDISPLAYLINE6OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE6_LINE_OnChange_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1015;
        SDISPLAYLINE7TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE6_LINE )  ) ; 
        __context__.SourceCodeLine = 1016;
        SDISPLAYLINE7TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE7TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE7TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1017;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE7TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1018;
            DISPLAY_LINE_7_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1020;
            DISPLAY_LINE_7_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1021;
        Functions.ClearBuffer ( SDISPLAYLINE7OUT ) ; 
        __context__.SourceCodeLine = 1022;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE7TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE6  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE6  >= __FN_FORSTART_VAL__1) && (INSE6  <= __FN_FOREND_VAL__1) ) : ( (INSE6  <= __FN_FORSTART_VAL__1) && (INSE6  >= __FN_FOREND_VAL__1) ) ; INSE6  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1024;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE7TEMP , (int)( INSE6 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 1025;
                SDISPLAYLINE7OUT  .UpdateValue ( SDISPLAYLINE7OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE7TEMP , (int)( INSE6 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 1022;
            } 
        
        __context__.SourceCodeLine = 1027;
        DISPLAY_LINE_7_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE7OUT ,  (int) ( (Functions.Length( SDISPLAYLINE7OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE7_LINE_OnChange_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1033;
        SDISPLAYLINE8TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE7_LINE )  ) ; 
        __context__.SourceCodeLine = 1034;
        SDISPLAYLINE8TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE8TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE8TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1035;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Bit( SDISPLAYLINE8TEMP , (int)( 1 ) , (int)( 3 ) ) == 1))  ) ) 
            {
            __context__.SourceCodeLine = 1036;
            DISPLAY_LINE_8_IS_ACTIVE  .Value = (ushort) ( 1 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 1038;
            DISPLAY_LINE_8_IS_ACTIVE  .Value = (ushort) ( 0 ) ; 
            }
        
        __context__.SourceCodeLine = 1039;
        Functions.ClearBuffer ( SDISPLAYLINE8OUT ) ; 
        __context__.SourceCodeLine = 1040;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE8TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE7  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE7  >= __FN_FORSTART_VAL__1) && (INSE7  <= __FN_FOREND_VAL__1) ) : ( (INSE7  <= __FN_FORSTART_VAL__1) && (INSE7  >= __FN_FOREND_VAL__1) ) ; INSE7  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1042;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE8TEMP , (int)( INSE7 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 1043;
                SDISPLAYLINE8OUT  .UpdateValue ( SDISPLAYLINE8OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE8TEMP , (int)( INSE7 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 1040;
            } 
        
        __context__.SourceCodeLine = 1045;
        DISPLAY_LINE_8_TEXT  .UpdateValue ( Functions.Right ( SDISPLAYLINE8OUT ,  (int) ( (Functions.Length( SDISPLAYLINE8OUT ) - 1) ) )  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NSE8_LINE_OnChange_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 1051;
        SDISPLAYLINE9TEMP  .UpdateValue ( Functions.Remove ( "\u000D" , NSE8_LINE )  ) ; 
        __context__.SourceCodeLine = 1052;
        SDISPLAYLINE9TEMP  .UpdateValue ( Functions.Left ( SDISPLAYLINE9TEMP ,  (int) ( (Functions.Length( SDISPLAYLINE9TEMP ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 1053;
        Functions.ClearBuffer ( SDISPLAYLINE9OUT ) ; 
        __context__.SourceCodeLine = 1054;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SDISPLAYLINE9TEMP ); 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( INSE8  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INSE8  >= __FN_FORSTART_VAL__1) && (INSE8  <= __FN_FOREND_VAL__1) ) : ( (INSE8  <= __FN_FORSTART_VAL__1) && (INSE8  >= __FN_FOREND_VAL__1) ) ; INSE8  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 1056;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SDISPLAYLINE9TEMP , (int)( INSE8 ) ) != 0))  ) ) 
                {
                __context__.SourceCodeLine = 1057;
                SDISPLAYLINE9OUT  .UpdateValue ( SDISPLAYLINE9OUT + Functions.Chr (  (int) ( Byte( SDISPLAYLINE9TEMP , (int)( INSE8 ) ) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 1054;
            } 
        
        __context__.SourceCodeLine = 1059;
        DISPLAY_LINE_9_TEXT  .UpdateValue ( SDISPLAYLINE9OUT  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 1070;
        Functions.ClearBuffer ( SSIRIUSSTATIONTEXTTEMP ) ; 
        __context__.SourceCodeLine = 1071;
        SIRIUS_STATION_TEXT  .UpdateValue ( SSIRIUSSTATIONTEXTTEMP  ) ; 
        __context__.SourceCodeLine = 1073;
        Functions.ClearBuffer ( SSIRIUSLOCKTEXTTEMP ) ; 
        __context__.SourceCodeLine = 1074;
        SIRIUS_LOCK_TEXT  .UpdateValue ( SSIRIUSLOCKTEXTTEMP  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SSIRIUSSTATIONTEXTTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    SSIRIUSLOCKTEXTTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 4, this );
    SHDRADIOSTATIONTEXTTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 6, this );
    SHDRADIOSTATIONTEXTTEMP2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    SDISPLAYLINE1TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE2TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE3TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE4TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE5TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE6TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE7TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE8TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE9TEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE1OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE2OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE3OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE4OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE5OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE6OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE7OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE8OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    SDISPLAYLINE9OUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 111, this );
    
    HD_RADIO_KEYPAD_BACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( HD_RADIO_KEYPAD_BACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( HD_RADIO_KEYPAD_BACKSPACE__DigitalInput__, HD_RADIO_KEYPAD_BACKSPACE );
    
    HD_RADIO_KEYPAD_CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( HD_RADIO_KEYPAD_CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( HD_RADIO_KEYPAD_CLEAR__DigitalInput__, HD_RADIO_KEYPAD_CLEAR );
    
    HD_RADIO_KEYPAD_ENTER = new Crestron.Logos.SplusObjects.DigitalInput( HD_RADIO_KEYPAD_ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( HD_RADIO_KEYPAD_ENTER__DigitalInput__, HD_RADIO_KEYPAD_ENTER );
    
    SIRIUS_KEYPAD = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        SIRIUS_KEYPAD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SIRIUS_KEYPAD__DigitalInput__ + i, SIRIUS_KEYPAD__DigitalInput__, this );
        m_DigitalInputList.Add( SIRIUS_KEYPAD__DigitalInput__ + i, SIRIUS_KEYPAD[i+1] );
    }
    
    SIRIUS_LOCK_KEYPAD = new InOutArray<DigitalInput>( 13, this );
    for( uint i = 0; i < 13; i++ )
    {
        SIRIUS_LOCK_KEYPAD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SIRIUS_LOCK_KEYPAD__DigitalInput__ + i, SIRIUS_LOCK_KEYPAD__DigitalInput__, this );
        m_DigitalInputList.Add( SIRIUS_LOCK_KEYPAD__DigitalInput__ + i, SIRIUS_LOCK_KEYPAD[i+1] );
    }
    
    HD_RADIO_KEYPAD = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        HD_RADIO_KEYPAD[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( HD_RADIO_KEYPAD__DigitalInput__ + i, HD_RADIO_KEYPAD__DigitalInput__, this );
        m_DigitalInputList.Add( HD_RADIO_KEYPAD__DigitalInput__ + i, HD_RADIO_KEYPAD[i+1] );
    }
    
    DISPLAY_LINE_2_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_2_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_2_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_2_IS_ACTIVE );
    
    DISPLAY_LINE_3_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_3_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_3_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_3_IS_ACTIVE );
    
    DISPLAY_LINE_4_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_4_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_4_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_4_IS_ACTIVE );
    
    DISPLAY_LINE_5_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_5_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_5_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_5_IS_ACTIVE );
    
    DISPLAY_LINE_6_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_6_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_6_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_6_IS_ACTIVE );
    
    DISPLAY_LINE_7_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_7_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_7_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_7_IS_ACTIVE );
    
    DISPLAY_LINE_8_IS_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( DISPLAY_LINE_8_IS_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISPLAY_LINE_8_IS_ACTIVE__DigitalOutput__, DISPLAY_LINE_8_IS_ACTIVE );
    
    HD_RADIO_BAND = new Crestron.Logos.SplusObjects.AnalogInput( HD_RADIO_BAND__AnalogSerialInput__, this );
    m_AnalogInputList.Add( HD_RADIO_BAND__AnalogSerialInput__, HD_RADIO_BAND );
    
    MAIN_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( MAIN_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MAIN_VALUE__AnalogSerialInput__, MAIN_VALUE );
    
    ZONE_2_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_2_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_2_VALUE__AnalogSerialInput__, ZONE_2_VALUE );
    
    ZONE_3_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( ZONE_3_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ZONE_3_VALUE__AnalogSerialInput__, ZONE_3_VALUE );
    
    FRONT_L_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_L_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_L_VALUE__AnalogSerialInput__, FRONT_L_VALUE );
    
    FRONT_R_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_R_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_R_VALUE__AnalogSerialInput__, FRONT_R_VALUE );
    
    CENTER_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( CENTER_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CENTER_VALUE__AnalogSerialInput__, CENTER_VALUE );
    
    SUBWOOFER_1_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SUBWOOFER_1_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SUBWOOFER_1_VALUE__AnalogSerialInput__, SUBWOOFER_1_VALUE );
    
    SUBWOOFER_2_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SUBWOOFER_2_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SUBWOOFER_2_VALUE__AnalogSerialInput__, SUBWOOFER_2_VALUE );
    
    SURROUND_L_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SURROUND_L_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SURROUND_L_VALUE__AnalogSerialInput__, SURROUND_L_VALUE );
    
    SURROUND_R_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SURROUND_R_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SURROUND_R_VALUE__AnalogSerialInput__, SURROUND_R_VALUE );
    
    SURROUND_BACK_L_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SURROUND_BACK_L_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SURROUND_BACK_L_VALUE__AnalogSerialInput__, SURROUND_BACK_L_VALUE );
    
    SURROUND_BACK_R_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SURROUND_BACK_R_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SURROUND_BACK_R_VALUE__AnalogSerialInput__, SURROUND_BACK_R_VALUE );
    
    SURROUND_BACK_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( SURROUND_BACK_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SURROUND_BACK_VALUE__AnalogSerialInput__, SURROUND_BACK_VALUE );
    
    FRONT_HEIGHT_L_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_HEIGHT_L_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_HEIGHT_L_VALUE__AnalogSerialInput__, FRONT_HEIGHT_L_VALUE );
    
    FRONT_HEIGHT_R_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_HEIGHT_R_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_HEIGHT_R_VALUE__AnalogSerialInput__, FRONT_HEIGHT_R_VALUE );
    
    FRONT_WIDE_L_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_WIDE_L_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_WIDE_L_VALUE__AnalogSerialInput__, FRONT_WIDE_L_VALUE );
    
    FRONT_WIDE_R_VALUE = new Crestron.Logos.SplusObjects.AnalogInput( FRONT_WIDE_R_VALUE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( FRONT_WIDE_R_VALUE__AnalogSerialInput__, FRONT_WIDE_R_VALUE );
    
    MAIN_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( MAIN_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MAIN_VOLUME_TO_SCALE__AnalogSerialOutput__, MAIN_VOLUME_TO_SCALE );
    
    ZONE_2_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_2_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_2_VOLUME_TO_SCALE__AnalogSerialOutput__, ZONE_2_VOLUME_TO_SCALE );
    
    ZONE_3_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( ZONE_3_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ZONE_3_VOLUME_TO_SCALE__AnalogSerialOutput__, ZONE_3_VOLUME_TO_SCALE );
    
    FRONT_L_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_L_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_L_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_L_VOLUME_TO_SCALE );
    
    FRONT_R_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_R_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_R_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_R_VOLUME_TO_SCALE );
    
    CENTER_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( CENTER_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CENTER_VOLUME_TO_SCALE__AnalogSerialOutput__, CENTER_VOLUME_TO_SCALE );
    
    SUBWOOFER_1_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SUBWOOFER_1_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SUBWOOFER_1_VOLUME_TO_SCALE__AnalogSerialOutput__, SUBWOOFER_1_VOLUME_TO_SCALE );
    
    SUBWOOFER_2_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SUBWOOFER_2_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SUBWOOFER_2_VOLUME_TO_SCALE__AnalogSerialOutput__, SUBWOOFER_2_VOLUME_TO_SCALE );
    
    SURROUND_L_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SURROUND_L_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SURROUND_L_VOLUME_TO_SCALE__AnalogSerialOutput__, SURROUND_L_VOLUME_TO_SCALE );
    
    SURROUND_R_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SURROUND_R_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SURROUND_R_VOLUME_TO_SCALE__AnalogSerialOutput__, SURROUND_R_VOLUME_TO_SCALE );
    
    SURROUND_BACK_L_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SURROUND_BACK_L_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SURROUND_BACK_L_VOLUME_TO_SCALE__AnalogSerialOutput__, SURROUND_BACK_L_VOLUME_TO_SCALE );
    
    SURROUND_BACK_R_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SURROUND_BACK_R_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SURROUND_BACK_R_VOLUME_TO_SCALE__AnalogSerialOutput__, SURROUND_BACK_R_VOLUME_TO_SCALE );
    
    SURROUND_BACK_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( SURROUND_BACK_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SURROUND_BACK_VOLUME_TO_SCALE__AnalogSerialOutput__, SURROUND_BACK_VOLUME_TO_SCALE );
    
    FRONT_HEIGHT_L_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_HEIGHT_L_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_HEIGHT_L_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_HEIGHT_L_VOLUME_TO_SCALE );
    
    FRONT_HEIGHT_R_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_HEIGHT_R_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_HEIGHT_R_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_HEIGHT_R_VOLUME_TO_SCALE );
    
    FRONT_WIDE_L_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_WIDE_L_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_WIDE_L_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_WIDE_L_VOLUME_TO_SCALE );
    
    FRONT_WIDE_R_VOLUME_TO_SCALE = new Crestron.Logos.SplusObjects.AnalogOutput( FRONT_WIDE_R_VOLUME_TO_SCALE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRONT_WIDE_R_VOLUME_TO_SCALE__AnalogSerialOutput__, FRONT_WIDE_R_VOLUME_TO_SCALE );
    
    NSE0_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE0_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE0_LINE__AnalogSerialInput__, NSE0_LINE );
    
    NSE1_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE1_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE1_LINE__AnalogSerialInput__, NSE1_LINE );
    
    NSE2_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE2_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE2_LINE__AnalogSerialInput__, NSE2_LINE );
    
    NSE3_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE3_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE3_LINE__AnalogSerialInput__, NSE3_LINE );
    
    NSE4_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE4_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE4_LINE__AnalogSerialInput__, NSE4_LINE );
    
    NSE5_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE5_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE5_LINE__AnalogSerialInput__, NSE5_LINE );
    
    NSE6_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE6_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE6_LINE__AnalogSerialInput__, NSE6_LINE );
    
    NSE7_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE7_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE7_LINE__AnalogSerialInput__, NSE7_LINE );
    
    NSE8_LINE = new Crestron.Logos.SplusObjects.StringInput( NSE8_LINE__AnalogSerialInput__, 115, this );
    m_StringInputList.Add( NSE8_LINE__AnalogSerialInput__, NSE8_LINE );
    
    SIRIUS_STATION_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_STATION_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_STATION_TEXT__AnalogSerialOutput__, SIRIUS_STATION_TEXT );
    
    SIRIUS_LOCK_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SIRIUS_LOCK_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SIRIUS_LOCK_TEXT__AnalogSerialOutput__, SIRIUS_LOCK_TEXT );
    
    HD_RADIO_STATION_TEXT = new Crestron.Logos.SplusObjects.StringOutput( HD_RADIO_STATION_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HD_RADIO_STATION_TEXT__AnalogSerialOutput__, HD_RADIO_STATION_TEXT );
    
    TO_DEVICE = new Crestron.Logos.SplusObjects.StringOutput( TO_DEVICE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_DEVICE__AnalogSerialOutput__, TO_DEVICE );
    
    MAIN_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( MAIN_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MAIN_VOLUME_TEXT__AnalogSerialOutput__, MAIN_VOLUME_TEXT );
    
    ZONE_2_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE_2_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE_2_VOLUME_TEXT__AnalogSerialOutput__, ZONE_2_VOLUME_TEXT );
    
    ZONE_3_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( ZONE_3_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ZONE_3_VOLUME_TEXT__AnalogSerialOutput__, ZONE_3_VOLUME_TEXT );
    
    FRONT_L_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_L_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_L_VOLUME_TEXT__AnalogSerialOutput__, FRONT_L_VOLUME_TEXT );
    
    FRONT_R_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_R_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_R_VOLUME_TEXT__AnalogSerialOutput__, FRONT_R_VOLUME_TEXT );
    
    CENTER_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( CENTER_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CENTER_VOLUME_TEXT__AnalogSerialOutput__, CENTER_VOLUME_TEXT );
    
    SUBWOOFER_1_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SUBWOOFER_1_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUBWOOFER_1_VOLUME_TEXT__AnalogSerialOutput__, SUBWOOFER_1_VOLUME_TEXT );
    
    SUBWOOFER_2_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SUBWOOFER_2_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SUBWOOFER_2_VOLUME_TEXT__AnalogSerialOutput__, SUBWOOFER_2_VOLUME_TEXT );
    
    SURROUND_L_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SURROUND_L_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SURROUND_L_VOLUME_TEXT__AnalogSerialOutput__, SURROUND_L_VOLUME_TEXT );
    
    SURROUND_R_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SURROUND_R_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SURROUND_R_VOLUME_TEXT__AnalogSerialOutput__, SURROUND_R_VOLUME_TEXT );
    
    SURROUND_BACK_L_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SURROUND_BACK_L_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SURROUND_BACK_L_VOLUME_TEXT__AnalogSerialOutput__, SURROUND_BACK_L_VOLUME_TEXT );
    
    SURROUND_BACK_R_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SURROUND_BACK_R_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SURROUND_BACK_R_VOLUME_TEXT__AnalogSerialOutput__, SURROUND_BACK_R_VOLUME_TEXT );
    
    SURROUND_BACK_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( SURROUND_BACK_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SURROUND_BACK_VOLUME_TEXT__AnalogSerialOutput__, SURROUND_BACK_VOLUME_TEXT );
    
    FRONT_HEIGHT_L_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_HEIGHT_L_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_HEIGHT_L_VOLUME_TEXT__AnalogSerialOutput__, FRONT_HEIGHT_L_VOLUME_TEXT );
    
    FRONT_HEIGHT_R_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_HEIGHT_R_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_HEIGHT_R_VOLUME_TEXT__AnalogSerialOutput__, FRONT_HEIGHT_R_VOLUME_TEXT );
    
    FRONT_WIDE_L_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_WIDE_L_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_WIDE_L_VOLUME_TEXT__AnalogSerialOutput__, FRONT_WIDE_L_VOLUME_TEXT );
    
    FRONT_WIDE_R_VOLUME_TEXT = new Crestron.Logos.SplusObjects.StringOutput( FRONT_WIDE_R_VOLUME_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRONT_WIDE_R_VOLUME_TEXT__AnalogSerialOutput__, FRONT_WIDE_R_VOLUME_TEXT );
    
    DISPLAY_LINE_1_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_1_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_1_TEXT__AnalogSerialOutput__, DISPLAY_LINE_1_TEXT );
    
    DISPLAY_LINE_2_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_2_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_2_TEXT__AnalogSerialOutput__, DISPLAY_LINE_2_TEXT );
    
    DISPLAY_LINE_3_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_3_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_3_TEXT__AnalogSerialOutput__, DISPLAY_LINE_3_TEXT );
    
    DISPLAY_LINE_4_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_4_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_4_TEXT__AnalogSerialOutput__, DISPLAY_LINE_4_TEXT );
    
    DISPLAY_LINE_5_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_5_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_5_TEXT__AnalogSerialOutput__, DISPLAY_LINE_5_TEXT );
    
    DISPLAY_LINE_6_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_6_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_6_TEXT__AnalogSerialOutput__, DISPLAY_LINE_6_TEXT );
    
    DISPLAY_LINE_7_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_7_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_7_TEXT__AnalogSerialOutput__, DISPLAY_LINE_7_TEXT );
    
    DISPLAY_LINE_8_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_8_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_8_TEXT__AnalogSerialOutput__, DISPLAY_LINE_8_TEXT );
    
    DISPLAY_LINE_9_TEXT = new Crestron.Logos.SplusObjects.StringOutput( DISPLAY_LINE_9_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DISPLAY_LINE_9_TEXT__AnalogSerialOutput__, DISPLAY_LINE_9_TEXT );
    
    
    for( uint i = 0; i < 13; i++ )
        SIRIUS_KEYPAD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SIRIUS_KEYPAD_OnPush_0, false ) );
        
    for( uint i = 0; i < 13; i++ )
        SIRIUS_LOCK_KEYPAD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SIRIUS_LOCK_KEYPAD_OnPush_1, false ) );
        
    for( uint i = 0; i < 10; i++ )
        HD_RADIO_KEYPAD[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( HD_RADIO_KEYPAD_OnPush_2, false ) );
        
    HD_RADIO_BAND.OnAnalogChange.Add( new InputChangeHandlerWrapper( HD_RADIO_BAND_OnChange_3, false ) );
    HD_RADIO_KEYPAD_BACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( HD_RADIO_KEYPAD_BACKSPACE_OnPush_4, false ) );
    HD_RADIO_KEYPAD_CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( HD_RADIO_KEYPAD_CLEAR_OnPush_5, false ) );
    HD_RADIO_KEYPAD_ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( HD_RADIO_KEYPAD_ENTER_OnPush_6, false ) );
    MAIN_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( MAIN_VALUE_OnChange_7, false ) );
    ZONE_2_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_2_VALUE_OnChange_8, false ) );
    ZONE_3_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ZONE_3_VALUE_OnChange_9, false ) );
    FRONT_L_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_L_VALUE_OnChange_10, false ) );
    FRONT_R_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_R_VALUE_OnChange_11, false ) );
    CENTER_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( CENTER_VALUE_OnChange_12, false ) );
    SUBWOOFER_1_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SUBWOOFER_1_VALUE_OnChange_13, false ) );
    SUBWOOFER_2_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SUBWOOFER_2_VALUE_OnChange_14, false ) );
    SURROUND_L_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SURROUND_L_VALUE_OnChange_15, false ) );
    SURROUND_R_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SURROUND_R_VALUE_OnChange_16, false ) );
    SURROUND_BACK_L_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SURROUND_BACK_L_VALUE_OnChange_17, false ) );
    SURROUND_BACK_R_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SURROUND_BACK_R_VALUE_OnChange_18, false ) );
    SURROUND_BACK_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SURROUND_BACK_VALUE_OnChange_19, false ) );
    FRONT_HEIGHT_L_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_HEIGHT_L_VALUE_OnChange_20, false ) );
    FRONT_HEIGHT_R_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_HEIGHT_R_VALUE_OnChange_21, false ) );
    FRONT_WIDE_L_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_WIDE_L_VALUE_OnChange_22, false ) );
    FRONT_WIDE_R_VALUE.OnAnalogChange.Add( new InputChangeHandlerWrapper( FRONT_WIDE_R_VALUE_OnChange_23, false ) );
    NSE0_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE0_LINE_OnChange_24, false ) );
    NSE1_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE1_LINE_OnChange_25, false ) );
    NSE2_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE2_LINE_OnChange_26, false ) );
    NSE3_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE3_LINE_OnChange_27, false ) );
    NSE4_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE4_LINE_OnChange_28, false ) );
    NSE5_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE5_LINE_OnChange_29, false ) );
    NSE6_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE6_LINE_OnChange_30, false ) );
    NSE7_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE7_LINE_OnChange_31, false ) );
    NSE8_LINE.OnSerialChange.Add( new InputChangeHandlerWrapper( NSE8_LINE_OnChange_32, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public CrestronModuleClass_MARANTZ_SR7005_V1_1_PROCESSOR ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint HD_RADIO_KEYPAD_BACKSPACE__DigitalInput__ = 0;
const uint HD_RADIO_KEYPAD_CLEAR__DigitalInput__ = 1;
const uint HD_RADIO_KEYPAD_ENTER__DigitalInput__ = 2;
const uint SIRIUS_KEYPAD__DigitalInput__ = 3;
const uint SIRIUS_LOCK_KEYPAD__DigitalInput__ = 16;
const uint HD_RADIO_KEYPAD__DigitalInput__ = 29;
const uint HD_RADIO_BAND__AnalogSerialInput__ = 0;
const uint MAIN_VALUE__AnalogSerialInput__ = 1;
const uint ZONE_2_VALUE__AnalogSerialInput__ = 2;
const uint ZONE_3_VALUE__AnalogSerialInput__ = 3;
const uint FRONT_L_VALUE__AnalogSerialInput__ = 4;
const uint FRONT_R_VALUE__AnalogSerialInput__ = 5;
const uint CENTER_VALUE__AnalogSerialInput__ = 6;
const uint SUBWOOFER_1_VALUE__AnalogSerialInput__ = 7;
const uint SUBWOOFER_2_VALUE__AnalogSerialInput__ = 8;
const uint SURROUND_L_VALUE__AnalogSerialInput__ = 9;
const uint SURROUND_R_VALUE__AnalogSerialInput__ = 10;
const uint SURROUND_BACK_L_VALUE__AnalogSerialInput__ = 11;
const uint SURROUND_BACK_R_VALUE__AnalogSerialInput__ = 12;
const uint SURROUND_BACK_VALUE__AnalogSerialInput__ = 13;
const uint FRONT_HEIGHT_L_VALUE__AnalogSerialInput__ = 14;
const uint FRONT_HEIGHT_R_VALUE__AnalogSerialInput__ = 15;
const uint FRONT_WIDE_L_VALUE__AnalogSerialInput__ = 16;
const uint FRONT_WIDE_R_VALUE__AnalogSerialInput__ = 17;
const uint NSE0_LINE__AnalogSerialInput__ = 18;
const uint NSE1_LINE__AnalogSerialInput__ = 19;
const uint NSE2_LINE__AnalogSerialInput__ = 20;
const uint NSE3_LINE__AnalogSerialInput__ = 21;
const uint NSE4_LINE__AnalogSerialInput__ = 22;
const uint NSE5_LINE__AnalogSerialInput__ = 23;
const uint NSE6_LINE__AnalogSerialInput__ = 24;
const uint NSE7_LINE__AnalogSerialInput__ = 25;
const uint NSE8_LINE__AnalogSerialInput__ = 26;
const uint MAIN_VOLUME_TO_SCALE__AnalogSerialOutput__ = 0;
const uint ZONE_2_VOLUME_TO_SCALE__AnalogSerialOutput__ = 1;
const uint ZONE_3_VOLUME_TO_SCALE__AnalogSerialOutput__ = 2;
const uint FRONT_L_VOLUME_TO_SCALE__AnalogSerialOutput__ = 3;
const uint FRONT_R_VOLUME_TO_SCALE__AnalogSerialOutput__ = 4;
const uint CENTER_VOLUME_TO_SCALE__AnalogSerialOutput__ = 5;
const uint SUBWOOFER_1_VOLUME_TO_SCALE__AnalogSerialOutput__ = 6;
const uint SUBWOOFER_2_VOLUME_TO_SCALE__AnalogSerialOutput__ = 7;
const uint SURROUND_L_VOLUME_TO_SCALE__AnalogSerialOutput__ = 8;
const uint SURROUND_R_VOLUME_TO_SCALE__AnalogSerialOutput__ = 9;
const uint SURROUND_BACK_L_VOLUME_TO_SCALE__AnalogSerialOutput__ = 10;
const uint SURROUND_BACK_R_VOLUME_TO_SCALE__AnalogSerialOutput__ = 11;
const uint SURROUND_BACK_VOLUME_TO_SCALE__AnalogSerialOutput__ = 12;
const uint FRONT_HEIGHT_L_VOLUME_TO_SCALE__AnalogSerialOutput__ = 13;
const uint FRONT_HEIGHT_R_VOLUME_TO_SCALE__AnalogSerialOutput__ = 14;
const uint FRONT_WIDE_L_VOLUME_TO_SCALE__AnalogSerialOutput__ = 15;
const uint FRONT_WIDE_R_VOLUME_TO_SCALE__AnalogSerialOutput__ = 16;
const uint SIRIUS_STATION_TEXT__AnalogSerialOutput__ = 17;
const uint SIRIUS_LOCK_TEXT__AnalogSerialOutput__ = 18;
const uint HD_RADIO_STATION_TEXT__AnalogSerialOutput__ = 19;
const uint TO_DEVICE__AnalogSerialOutput__ = 20;
const uint MAIN_VOLUME_TEXT__AnalogSerialOutput__ = 21;
const uint ZONE_2_VOLUME_TEXT__AnalogSerialOutput__ = 22;
const uint ZONE_3_VOLUME_TEXT__AnalogSerialOutput__ = 23;
const uint FRONT_L_VOLUME_TEXT__AnalogSerialOutput__ = 24;
const uint FRONT_R_VOLUME_TEXT__AnalogSerialOutput__ = 25;
const uint CENTER_VOLUME_TEXT__AnalogSerialOutput__ = 26;
const uint SUBWOOFER_1_VOLUME_TEXT__AnalogSerialOutput__ = 27;
const uint SUBWOOFER_2_VOLUME_TEXT__AnalogSerialOutput__ = 28;
const uint SURROUND_L_VOLUME_TEXT__AnalogSerialOutput__ = 29;
const uint SURROUND_R_VOLUME_TEXT__AnalogSerialOutput__ = 30;
const uint SURROUND_BACK_L_VOLUME_TEXT__AnalogSerialOutput__ = 31;
const uint SURROUND_BACK_R_VOLUME_TEXT__AnalogSerialOutput__ = 32;
const uint SURROUND_BACK_VOLUME_TEXT__AnalogSerialOutput__ = 33;
const uint FRONT_HEIGHT_L_VOLUME_TEXT__AnalogSerialOutput__ = 34;
const uint FRONT_HEIGHT_R_VOLUME_TEXT__AnalogSerialOutput__ = 35;
const uint FRONT_WIDE_L_VOLUME_TEXT__AnalogSerialOutput__ = 36;
const uint FRONT_WIDE_R_VOLUME_TEXT__AnalogSerialOutput__ = 37;
const uint DISPLAY_LINE_1_TEXT__AnalogSerialOutput__ = 38;
const uint DISPLAY_LINE_2_TEXT__AnalogSerialOutput__ = 39;
const uint DISPLAY_LINE_3_TEXT__AnalogSerialOutput__ = 40;
const uint DISPLAY_LINE_4_TEXT__AnalogSerialOutput__ = 41;
const uint DISPLAY_LINE_5_TEXT__AnalogSerialOutput__ = 42;
const uint DISPLAY_LINE_6_TEXT__AnalogSerialOutput__ = 43;
const uint DISPLAY_LINE_7_TEXT__AnalogSerialOutput__ = 44;
const uint DISPLAY_LINE_8_TEXT__AnalogSerialOutput__ = 45;
const uint DISPLAY_LINE_9_TEXT__AnalogSerialOutput__ = 46;
const uint DISPLAY_LINE_2_IS_ACTIVE__DigitalOutput__ = 0;
const uint DISPLAY_LINE_3_IS_ACTIVE__DigitalOutput__ = 1;
const uint DISPLAY_LINE_4_IS_ACTIVE__DigitalOutput__ = 2;
const uint DISPLAY_LINE_5_IS_ACTIVE__DigitalOutput__ = 3;
const uint DISPLAY_LINE_6_IS_ACTIVE__DigitalOutput__ = 4;
const uint DISPLAY_LINE_7_IS_ACTIVE__DigitalOutput__ = 5;
const uint DISPLAY_LINE_8_IS_ACTIVE__DigitalOutput__ = 6;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
