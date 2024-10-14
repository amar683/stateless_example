It's an example of a question that can be solved using the Stateless state machine library in C#:

Question:
You are building an order management system for an e-commerce platform. The system needs to manage the state of orders as they move through different stages such as Created, Paid, Shipped, and Delivered. Each state transition should only occur in a specific sequence:

An order is initially in the Created state.
After the payment is successful, the order moves to the Paid state.
Once the order is packaged and handed over to the shipping company, it transitions to the Shipped state.
When the customer receives the order, it moves to the Delivered state.
Write a program in C# using the Stateless library to model this order lifecycle with appropriate state transitions. Ensure that invalid transitions, such as shipping an order before it's paid, are not allowed.

Requirements:
Define an OrderState enum with values: Created, Paid, Shipped, Delivered.
Use the Stateless library to define valid state transitions.
Write a function that triggers a state transition and logs the current state after each valid transition.
