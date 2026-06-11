using System;
using VNMCMotionSDK;

namespace PCB_PLC
{
    public static class IO
    {
        private static NMCSDKLib.MC_STATUS lastStatus;

        public static NMCSDKLib.MC_STATUS Initialize()
        {
            lastStatus = NMCSDKLib.MC_MasterInit(0);
            if (lastStatus == NMCSDKLib.MC_STATUS.MC_OK)
            {
                lastStatus = NMCSDKLib.MC_MasterRUN(0);
            }
            return lastStatus;
        }

        public static NMCSDKLib.MC_STATUS Shutdown()
        {
            lastStatus = NMCSDKLib.MC_MasterSTOP(0);
            return lastStatus;
        }

        public static bool ReadInput(byte bitNum)
        {
            uint offset = IOMap.Input.OFFSET + (uint)(bitNum / 8);
            byte bitOffset = (byte)(bitNum % 8);
            bool data = false;

            // BufferInOut = 0 for inputs (Offset 4)
            lastStatus = NMCSDKLib.MC_IO_READ_BIT(0, 0, 0, offset, bitOffset, ref data);
            return data;
        }

        public static bool ReadOutput(byte bitNum)
        {
            uint offset = IOMap.Output.OFFSET + (uint)(bitNum / 8);
            byte bitOffset = (byte)(bitNum % 8);
            bool data = false;

            // BufferInOut = 1 for outputs (Offset 0)
            lastStatus = NMCSDKLib.MC_IO_READ_BIT(0, 0, 1, offset, bitOffset, ref data);
            return data;
        }

        public static void WriteOutput(byte bitNum, bool value)
        {
            uint offset = IOMap.Output.OFFSET + (uint)(bitNum / 8);
            byte bitOffset = (byte)(bitNum % 8);

            lastStatus = NMCSDKLib.MC_IO_WRITE_BIT(0, 0, offset, bitOffset, value);
        }

        public static uint ReadInputDWord()
        {
            uint inData = 0;
            // BufferInOut = 0 for inputs, Offset = 4
            lastStatus = NMCSDKLib.MC_IO_READ_DWORD(0, 0, 0, IOMap.Input.OFFSET, ref inData);
            return inData;
        }

        public static uint ReadOutputDWord()
        {
            uint outData = 0;
            // BufferInOut = 1 for outputs, Offset = 0
            lastStatus = NMCSDKLib.MC_IO_READ_DWORD(0, 0, 1, IOMap.Output.OFFSET, ref outData);
            return outData;
        }

        // --- 편리한 단축 속성 및 메서드 정의 ---

        // 센서류 입력 속성
        public static bool IsWorkDetected => ReadInput(IOMap.Input.WORK_DETECT);
        public static bool IsSquareWorkDetected => ReadInput(IOMap.Input.SQ_WORK_DETECT);
        public static bool IsInductiveSensorOn => ReadInput(IOMap.Input.INDUCTIVE);
        public static bool IsCapacitiveSensorOn => ReadInput(IOMap.Input.CAPACITIVE);
        public static bool IsStopperDetected => ReadInput(IOMap.Input.STOPPER_DETECT);
        public static bool IsStackSuctionOn => ReadInput(IOMap.Input.STACK_SUCTION);

        // 리프트 센서 입력 속성
        public static bool IsLiftAtBottom => ReadInput(IOMap.Input.LIFT_LV_W);
        public static bool IsLiftAtLevel1 => ReadInput(IOMap.Input.LIFT_LV_1);
        public static bool IsLiftAtLevel2 => ReadInput(IOMap.Input.LIFT_LV_2);
        public static bool IsLiftAtLevel3 => ReadInput(IOMap.Input.LIFT_LV_3);

        // 모터 및 기기 직접 제어/조회
        public static bool IsSuctionOn => ReadOutput(IOMap.Output.SUCTION);
        public static void SetSuction(bool state) => WriteOutput(IOMap.Output.SUCTION, state);

        public static bool IsDrillMotorOn => ReadOutput(IOMap.Output.DRILL_MOTOR);
        public static void SetDrillMotor(bool state) => WriteOutput(IOMap.Output.DRILL_MOTOR, state);

        public static bool IsConveyorOn => ReadOutput(IOMap.Output.CONVEYOR);
        public static void SetConveyor(bool state) => WriteOutput(IOMap.Output.CONVEYOR, state);

        public static bool IsLiftGoingUp => ReadOutput(IOMap.Output.LIFT_UP);
        public static void SetLiftUp(bool state) => WriteOutput(IOMap.Output.LIFT_UP, state);

        public static bool IsLiftGoingDown => ReadOutput(IOMap.Output.LIFT_DOWN);
        public static void SetLiftDown(bool state) => WriteOutput(IOMap.Output.LIFT_DOWN, state);
    }
}
