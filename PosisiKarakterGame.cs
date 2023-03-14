using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod4_1302210014
{
    internal class PosisiKarakterGame
    {
        public enum KarakterState
        {
            Berdiri,
            Jongkok,
            Terbang,
            Tengkurap
        }
        public enum KarakterTrigger
        {
            TombolW,
            TombolS,
            TombolX
        }

        private class Transition
        {
            public KarakterState curState;
            public KarakterState nextState;
            public KarakterTrigger trigger;
            public Transition (KarakterState cur, KarakterState next, KarakterTrigger trig)
            {
                this.curState = cur;
                this.nextState = next;
                this.trigger = trig;
            }
        }

        Transition[] transitions = new Transition[] {
            new Transition(KarakterState.Jongkok, KarakterState.Berdiri, KarakterTrigger.TombolW),
            new Transition(KarakterState.Jongkok, KarakterState.Tengkurap, KarakterTrigger.TombolS),
            new Transition(KarakterState.Berdiri, KarakterState.Terbang, KarakterTrigger.TombolW),
            new Transition(KarakterState.Berdiri, KarakterState.Jongkok, KarakterTrigger.TombolS),
            new Transition(KarakterState.Terbang, KarakterState.Berdiri, KarakterTrigger.TombolS),
            new Transition(KarakterState.Terbang, KarakterState.Jongkok, KarakterTrigger.TombolX),
            new Transition(KarakterState.Tengkurap, KarakterState.Jongkok, KarakterTrigger.TombolW)
        };

        public KarakterState currentState = KarakterState.Berdiri;
    
        private KarakterState getNextState(KarakterState curState, KarakterTrigger trig)
        {
            KarakterState nextState = this.currentState;
            for (int i = 0; i < transitions.Length; i++)
            {
                if (transitions[i].curState == curState && transitions[i].trigger == trig)
                {
                    nextState = transitions[i].nextState; break;
                }
            }
            return nextState;
        }
        public void activateTrigger(KarakterTrigger trig)
        {
            KarakterState nextState = getNextState(this.currentState, trig);
            if (this.currentState == KarakterState.Terbang && nextState == KarakterState.Jongkok)
            {
                Console.WriteLine("posisi landing");
            } else if (this.currentState == KarakterState.Berdiri && nextState == KarakterState.Terbang)
            {
                Console.WriteLine("posisi take off");
            }
            this.currentState = nextState;
        }
    }
}
