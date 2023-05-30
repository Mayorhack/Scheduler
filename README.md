# Scheduler
#### The Scheduler API is a versatile tool that enables seamless integration of appointment scheduling functionality into applications. It offers features for creating, managing, and deleting appointments, as well as defining availability and scheduling rules. . The API supports user authentication, customization, and seamless integration with existing systems, making it an ideal.
## Appointment

It entails every CRUD application for appointments. It can only be access by authenticated users

Authorization: Bearer {{token}}

**GET**   GetById
Get appointment by id
Request
`curl --location 'https://localhost:7225/api/Appointment/5'`

Response
```json
{
  "data": {
    "id": 0,
    "title": "string",
    "description": "string",
    "createdDate": "2023-05-30T11:03:39.189Z",
    "appointmentDate": "2023-05-30T11:03:39.189Z",
    "userId": 0
  },
  "success": true,
  "message": "string"
}
```
**GET**   GetAll
Get all appointments created by an authenticated user
Request
`curl --location 'https://localhost:7225/api/Appointment/getAll'`

Response

```json
{
  "data":[ 
  {
    "id": 0,
    "title": "string",
    "description": "string",
    "createdDate": "2023-05-30T11:02:51.977Z",
    "appointmentDate": "2023-05-30T11:02:51.977Z",
    "userId": 0
  }
  ],
  "success": true,
  "message": "string"
}
```
**POST**   Add Appointments
Request
`curl --location 'https://localhost:7225/api/Appointment'`


Body
```json
{
  "title": "string",
  "description": "string",
  "appointmentDate": "2023-05-30T11:10:08.362Z"
}
```
Response
```json
{
  "data": {
    "id": 0,
    "title": "string",
    "description": "string",
    "createdDate": "2023-05-30T11:12:27.571Z",
    "appointmentDate": "2023-05-30T11:12:27.571Z",
    "userId": 0
  },
  "success": true,
  "message": "string"
}
```

**PUT**   Update Appointment

Request
`curl --location 'https://localhost:7225/api/Appointment'`

Body
```json
{
  "id": 0,
  "title": "string",
  "description": "string",
  "appointmentDate": "2023-05-30T11:12:27.576Z"
}
```
Response
```json
{
  "data": [
    {
      "id": 0,
      "title": "string",
      "description": "string",
      "createdDate": "2023-05-30T11:12:27.607Z",
      "appointmentDate": "2023-05-30T11:12:27.607Z",
      "userId": 0
    }
  ],
  "success": true,
  "message": "string"
}
```
**Delete**   Delete Appointment
Request
`curl --location 'https://localhost:7225/api/Appointment?id=5'`
Query
id 						5
Response
```json
{
  "data": [
    {
      "id": 0,
      "title": "string",
      "description": "string",
      "createdDate": "2023-05-30T11:15:18.891Z",
      "appointmentDate": "2023-05-30T11:15:18.891Z",
      "userId": 0
    }
  ],
  "success": true,
  "message": "string"
}
```
## Authentication

Authentication Endpoint to add and login users

**POST**   Login
Request
`curl --location 'https://localhost:7225/api/Authentication/Login'`


Body
```json
{
  "username": "string",
  "email": "user@example.com",
  "password": "string",
  "role": "string"
}
```
Response
```json
{
  "data": 0,
  "success": true,
  "message": "string"
}
```
**POST**   Register
Request
`curl --location 'https://localhost:7225/api/Authentication/Register'`


Body
```json
{
  "username": "string",
  "password": "string"
}
```
Response
```json
{
  "data": 0,
  "success": true,
  "message": "string"
}
```
## User

Entails all CRUD application for user endpoint

Authorization: Bearer {{token}}

**GET**   GetById
Get user by id
Request
`curl --location 'https://localhost:7225/api/user/5'`

Response
```json
{
  "data": {
    "id": 0,
    "username": "string",
    "email": "string",
    "isAdmin": "string",
    "passwordHash": "string",
    "passwordSalt": "string",
    "appointments": [
      {
        "id": 0,
        "title": "string",
        "description": "string",
        "createdDate": "2023-05-30T11:21:24.887Z",
        "appointmentDate": "2023-05-30T11:21:24.887Z",
        "userId": 0
      }
    ]
  },
  "success": true,
  "message": "string"
}
```
**GET**   GetUsers
Get all appointments created by an authenticated user
Request
`curl --location 'https://localhost:7225/api/User'`

Response

```json
{
  "data": [
    {
      "id": 0,
      "username": "string",
      "email": "string",
      "isAdmin": "string",
      "passwordHash": "string",
      "passwordSalt": "string",
      "appointments": [
        {
          "id": 0,
          "title": "string",
          "description": "string",
          "createdDate": "2023-05-30T11:21:57.440Z",
          "appointmentDate": "2023-05-30T11:21:57.440Z",
          "userId": 0
        }
      ]
    }
  ],
  "success": true,
  "message": "string"
}
```
**POST**   Add User
Request
`curl --location 'https://localhost:7225/api/User'`

Body
```json
{
  "username": "string",
  "email": "user@example.com",
  "password": "string",
  "role": "string"
}
```
Response
```json
{
  "data": {
    "id": 0,
    "title": "string",
    "description": "string",
    "createdDate": "2023-05-30T11:23:10.539Z",
    "appointmentDate": "2023-05-30T11:23:10.539Z",
    "userId": 0
  },
  "success": true,
  "message": "string"
}
```
