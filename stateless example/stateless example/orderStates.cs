using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stateless;

namespace stateless_example
{
    class orderStates
    {
        public enum orderState
        {
            created,
            paid,
            shipped,
            delivered
        }
        public enum Trigger
        {
            pay,
            ship,
            deliver
        }
        private StateMachine<orderState, Trigger> _machine;
        public orderStates()
        {
            _machine = new StateMachine<orderState, Trigger>(orderState.created);

            _machine.Configure(orderState.created).Permit(Trigger.pay, orderState.paid);
            _machine.Configure(orderState.paid).Permit(Trigger.ship, orderState.shipped);
            _machine.Configure(orderState.created).Permit(Trigger.deliver, orderState.delivered);

        }
        public orderState GetState() => _machine.State;
        public void fire(Trigger trigger)
        {
            try
            {
                _machine.Fire(trigger);
                Console.WriteLine($"Order state changed to: {_machine.State}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Invalid transition: {ex.Message}");
            }
        }
        public void DisplayState()
        {
            Console.WriteLine($"Current order state: {_machine.State}");
        }
    }
}
