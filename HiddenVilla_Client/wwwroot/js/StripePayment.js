redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51IVH7BBuMtj0mRD4jyFXaTnN0rZCkXMlU8k7RMN096irrT4CQFuzDI0shttpWBPDa2wlHNlNqWrZvIXwSBwMlLwf00avhsPlwZ');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
};