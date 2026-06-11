using System.Collections.Generic;

namespace PCB_PLC
{
    public static class IOMap
    {
        // Inputs (BufferInOut = 0, starting from Offset 4)
        public static class Input
        {
            public const uint OFFSET = 4;

            // Address 4
            public const byte LOAD_BWD = 0;       // 공급 후진
            public const byte LOAD_FWD = 1;       // 공급 전진
            public const byte DRILL_UP = 2;       // 드릴 상승
            public const byte DRILL_DOWN = 3;     // 드릴 하강
            public const byte MOVE_BWD = 4;       // 분배 후진
            public const byte MOVE_FWD = 5;       // 분배 전진
            public const byte UNLD_BWD = 6;       // 취출 후진
            public const byte UNLD_FWD = 7;       // 취출 전진

            // Address 5
            public const byte STOPPER_UP = 8;      // 스토퍼 상승
            public const byte STOPPER_DOWN = 9;    // 스토퍼 하강
            public const byte STACK_BWD = 10;      // 적재 후진
            public const byte STACK_FWD = 11;      // 적재 전진
            public const byte CONT_BWD = 12;       // 창고 후진
            public const byte CONT_FWD = 13;       // 창고 전진
            public const byte WORK_DETECT = 14;    // 워크 검출
            public const byte SQ_WORK_DETECT = 15; // 사각워크검출

            // Address 6
            public const byte INDUCTIVE = 16;      // 유도형 센서
            public const byte CAPACITIVE = 17;     // 용량형 센서
            public const byte STOPPER_DETECT = 18; // 스토퍼 검출
            public const byte STACK_SUCTION = 19;  // 적재 흡착
            public const byte LIFT_LV_W = 20;      // LV_W (리프트 최하단)
            public const byte LIFT_LV_1 = 21;      // LV_1 (리프트 1단)
            public const byte LIFT_LV_2 = 22;      // LV_2 (리프트 2단)
            public const byte LIFT_LV_3 = 23;      // LV_3 (리프트 3단)

            // Address 7
            public const byte SIM_BTN_18 = 24;     // 시뮬레이터 버튼 X18
            public const byte SIM_BTN_19 = 25;     // 시뮬레이터 버튼 X19
            public const byte SIM_BTN_1A = 26;     // 시뮬레이터 버튼 X1A
            public const byte SIM_BTN_1B = 27;     // 시뮬레이터 버튼 X1B
            public const byte SIM_BTN_1C = 28;     // 시뮬레이터 버튼 X1C
            public const byte SIM_BTN_1D = 29;     // 시뮬레이터 버튼 X1D
            public const byte SIM_BTN_1E = 30;     // 시뮬레이터 버튼 X1E
            public const byte SIM_BTN_1F = 31;     // 시뮬레이터 버튼 X1F

            // 한글 명칭 매핑 사전 (IO 모니터링 화면 출력용)
            public static readonly Dictionary<byte, string> Names = new Dictionary<byte, string>
            {
                { LOAD_BWD, "공급 후진" },
                { LOAD_FWD, "공급 전진" },
                { DRILL_UP, "드릴 상승" },
                { DRILL_DOWN, "드릴 하강" },
                { MOVE_BWD, "분배 후진" },
                { MOVE_FWD, "분배 전진" },
                { UNLD_BWD, "취출 후진" },
                { UNLD_FWD, "취출 전진" },
                { STOPPER_UP, "스토퍼 상승" },
                { STOPPER_DOWN, "스토퍼 하강" },
                { STACK_BWD, "적재 후진" },
                { STACK_FWD, "적재 전진" },
                { CONT_BWD, "창고 후진" },
                { CONT_FWD, "창고 전진" },
                { WORK_DETECT, "워크 검출" },
                { SQ_WORK_DETECT, "사각워크검출" },
                { INDUCTIVE, "유도형 센서" },
                { CAPACITIVE, "용량형 센서" },
                { STOPPER_DETECT, "스토퍼 검출" },
                { STACK_SUCTION, "적재 흡착" },
                { LIFT_LV_W, "LV_W (최하단)" },
                { LIFT_LV_1, "LV_1" },
                { LIFT_LV_2, "LV_2" },
                { LIFT_LV_3, "LV_3" },
                { SIM_BTN_18, "시뮬레이터 버튼 X18" },
                { SIM_BTN_19, "시뮬레이터 버튼 X19" },
                { SIM_BTN_1A, "시뮬레이터 버튼 X1A" },
                { SIM_BTN_1B, "시뮬레이터 버튼 X1B" },
                { SIM_BTN_1C, "시뮬레이터 버튼 X1C" },
                { SIM_BTN_1D, "시뮬레이터 버튼 X1D" },
                { SIM_BTN_1E, "시뮬레이터 버튼 X1E" },
                { SIM_BTN_1F, "시뮬레이터 버튼 X1F" }
            };
        }

        // Outputs (BufferInOut = 1, starting from Offset 0)
        public static class Output
        {
            public const uint OFFSET = 0;

            // Address 0
            public const byte LOAD_FWD = 0;       // 공급 전진
            public const byte LOAD_BWD = 1;       // 공급 후진
            public const byte DRILL_SOL = 2;      // 드릴 실린더
            public const byte MOVE_FWD = 3;       // 분배 전진
            public const byte MOVE_BWD = 4;       // 분배 후진
            public const byte UNLD_FWD = 5;       // 취출 전진
            public const byte UNLD_BWD = 6;       // 취출 후진
            public const byte STACK_FWD = 7;      // 적재 전진

            // Address 1
            public const byte STACK_BWD = 8;      // 적재 후진
            public const byte SUCTION = 9;         // 흡착
            public const byte CONT_FWD = 10;      // 창고 전진
            public const byte CONT_BWD = 11;      // 창고 후진
            public const byte STOPPER = 12;       // 스토퍼 실린더
            public const byte DRILL_MOTOR = 13;   // 드릴 모터
            public const byte CONVEYOR = 14;      // 컨베이어
            public const byte RED_LAMP = 15;      // 시그널타워 Red

            // Address 2
            public const byte YELLOW_LAMP = 16;   // 시그널타워 Yellow
            public const byte GREEN_LAMP = 17;    // 시그널타워 Green
            public const byte LIFT_UP = 18;       // 리프트 F (상승)
            public const byte LIFT_DOWN = 19;     // 리프트 R (하강)

            // 한글 명칭 매핑 사전 (IO 모니터링 화면 출력용)
            public static readonly Dictionary<byte, string> Names = new Dictionary<byte, string>
            {
                { LOAD_FWD, "공급 전진" },
                { LOAD_BWD, "공급 후진" },
                { DRILL_SOL, "드릴 실린더" },
                { MOVE_FWD, "분배 전진" },
                { MOVE_BWD, "분배 후진" },
                { UNLD_FWD, "취출 전진" },
                { UNLD_BWD, "취출 후진" },
                { STACK_FWD, "적재 전진" },
                { STACK_BWD, "적재 후진" },
                { SUCTION, "흡착" },
                { CONT_FWD, "창고 전진" },
                { CONT_BWD, "창고 후진" },
                { STOPPER, "스토퍼 실린더" },
                { DRILL_MOTOR, "드릴 모터" },
                { CONVEYOR, "컨베이어" },
                { RED_LAMP, "시그널타워 Red" },
                { YELLOW_LAMP, "시그널타워 Yellow" },
                { GREEN_LAMP, "시그널타워 Green" },
                { LIFT_UP, "리프트 F (상승)" },
                { LIFT_DOWN, "리프트 R (하강)" }
            };
        }
    }
}
