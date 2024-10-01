# unify-notification-service
This is a utility application designed to handle the composition, delivery, and tracking of notifications like email, sms and push notifications. It abstracts the complexities of interfacing with email, sms servers or other third party providers and provides a simple interface for sending different types of notifications.

**Key Features**
1. **Template-Based Notifications:** This service allows users to add different templates for different channels like email, sms and push.
2. **Notification Composition:** The service supports the composition of email, sms or push notification.
3. **Asynchronous Notification Processing:** Notifications are sent asynchronously to improve application performance and avoids delays in user-facing operations.
4. **Scalability:** The service is designed to be scalable; the notification ingestation is separated from the channel processors..
5. **Scheduled Delivery**: This service supports scheduling notifications to a later time.
6. **Error Handling and Retry Mechanism:** The services includes error handling to catch delivery failures (e.g., network failure or invalid email addresses) supports configurable retry mechanisms to ensure notifications are delivered reliably.
7. **Logging and Tracking:** It logs email delivery attempts, errors, and successes, which can be used for audit or debugging purposes.


