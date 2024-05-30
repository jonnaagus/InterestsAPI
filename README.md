# InterestsAPI

Lägg till personer
![Skärmbild 2024-05-30 223622](https://github.com/jonnaagus/InterestsAPI/assets/144246531/96abf9c4-4237-4a44-bdd4-866a26a1b338)
![Skärmbild 2024-05-30 223822](https://github.com/jonnaagus/InterestsAPI/assets/144246531/4bd5ad90-d2b0-4c97-86a2-5c2af0548bb7)

Hämta alla personer
![Skärmbild 2024-05-30 224036](https://github.com/jonnaagus/InterestsAPI/assets/144246531/8b9dd9e6-f3fc-4cf9-8c74-c46007a0ae6a)

Response body:
```json
[
  {
    "personId": 1,
    "personName": "Jonna",
    "contact": "0987654321",
    "interestParticipations": [
      {
        "id": 1,
        "resources": [
          "https://www.svenskfotboll.se/lagsida/hogs-sk--iggesunds-ik/312351/"
        ],
        "fkPersonId": 1,
        "person": null,
        "fkInterestId": 1,
        "interest": null
      },
      {
        "id": 10,
        "resources": null,
        "fkPersonId": 1,
        "person": null,
        "fkInterestId": 3,
        "interest": null
      }
    ]
  },
  {
    "personId": 2,
    "personName": "Wille",
    "contact": "1122354321",
    "interestParticipations": [
      {
        "id": 2,
        "resources": [
          "https://www.hudiksvallsgym.se/"
        ],
        "fkPersonId": 2,
        "person": null,
        "fkInterestId": 3,
        "interest": null
      },
      {
        "id": 9,
        "resources": null,
        "fkPersonId": 2,
        "person": null,
        "fkInterestId": 7,
        "interest": null
      }
    ]
  },
  {
    "personId": 3,
    "personName": "Svante",
    "contact": "1122354111",
    "interestParticipations": [
      {
        "id": 3,
        "resources": [
          "https://www.laget.se/HudiksvallsHC-U10-Team2014/Troop"
        ],
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 2,
        "interest": null
      },
      {
        "id": 11,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 1,
        "interest": null
      },
      {
        "id": 12,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 5,
        "interest": null
      },
      {
        "id": 13,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 7,
        "interest": null
      }
    ]
  },
  {
    "personId": 4,
    "personName": "Ture",
    "contact": "2121343454",
    "interestParticipations": [
      {
        "id": 4,
        "resources": null,
        "fkPersonId": 4,
        "person": null,
        "fkInterestId": 5,
        "interest": null
      },
      {
        "id": 7,
        "resources": null,
        "fkPersonId": 4,
        "person": null,
        "fkInterestId": 7,
        "interest": null
      },
      {
        "id": 8,
        "resources": null,
        "fkPersonId": 4,
        "person": null,
        "fkInterestId": 1,
        "interest": null
      }
    ]
  },
  {
    "personId": 5,
    "personName": "Sigrid",
    "contact": "2266554411",
    "interestParticipations": [
      {
        "id": 5,
        "resources": null,
        "fkPersonId": 5,
        "person": null,
        "fkInterestId": 4,
        "interest": null
      },
      {
        "id": 6,
        "resources": null,
        "fkPersonId": 5,
        "person": null,
        "fkInterestId": 6,
        "interest": null
      }
    ]
  }
]
```
Hämta personer med ID
![Skärmbild 2024-05-30 224107](https://github.com/jonnaagus/InterestsAPI/assets/144246531/2321bcf1-c69c-4171-9772-d7d06339f8ca)
![Skärmbild 2024-05-30 224122](https://github.com/jonnaagus/InterestsAPI/assets/144246531/76836ce2-4ae3-47ab-9694-170666b142c9)
Response body:
```json
{
  "personId": 3,
  "personName": "Svante",
  "contact": "1122354111",
  "interestParticipations": [
    {
      "id": 3,
      "resources": [
        "https://www.laget.se/HudiksvallsHC-U10-Team2014/Troop"
      ],
      "fkPersonId": 3,
      "person": null,
      "fkInterestId": 2,
      "interest": {
        "interestId": 2,
        "title": "Hockey",
        "description": "Man åker med skridskor på isen och spelar med puck och klubba",
        "interestParticipations": [
          null
        ]
      }
    },
    {
      "id": 11,
      "resources": null,
      "fkPersonId": 3,
      "person": null,
      "fkInterestId": 1,
      "interest": {
        "interestId": 1,
        "title": "Fotboll",
        "description": "Man springer och sparkar på en boll, förhoppningsvis gör man en massa mål",
        "interestParticipations": [
          null
        ]
      }
    },
    {
      "id": 12,
      "resources": null,
      "fkPersonId": 3,
      "person": null,
      "fkInterestId": 5,
      "interest": {
        "interestId": 5,
        "title": "Cykla",
        "description": "Man trampar på en cykel och känner vinden fånga håret",
        "interestParticipations": [
          null
        ]
      }
    },
    {
      "id": 13,
      "resources": null,
      "fkPersonId": 3,
      "person": null,
      "fkInterestId": 7,
      "interest": {
        "interestId": 7,
        "title": "Bada",
        "description": "Att bada i poolen, havet, sjön, badkaret är roligt",
        "interestParticipations": [
          null
        ]
      }
    }
  ]
}
```
Lägg till intressen
![Skärmbild 2024-05-30 224244](https://github.com/jonnaagus/InterestsAPI/assets/144246531/d97b36b4-a5d0-4aed-9d84-f3629161b73b)
![Skärmbild 2024-05-30 224255](https://github.com/jonnaagus/InterestsAPI/assets/144246531/b2238e70-fcac-46eb-9b2a-5fd8b0868888)

Hämta alla intressen
![Skärmbild 2024-05-30 225720](https://github.com/jonnaagus/InterestsAPI/assets/144246531/73f99fc2-62fa-4746-a700-0d885698ad5f)
![Skärmbild 2024-05-30 225730](https://github.com/jonnaagus/InterestsAPI/assets/144246531/e7f3318f-dc1e-406c-a7cc-fe26497d9bf6)
Response body:
```json
[
  {
    "interestId": 1,
    "title": "Fotboll",
    "description": "Man springer och sparkar på en boll, förhoppningsvis gör man en massa mål",
    "interestParticipations": null
  },
  {
    "interestId": 2,
    "title": "Hockey",
    "description": "Man åker med skridskor på isen och spelar med puck och klubba",
    "interestParticipations": null
  },
  {
    "interestId": 3,
    "title": "Träna",
    "description": "Träna kondition och styrka på gymmet är svettigt men roligt",
    "interestParticipations": null
  },
  {
    "interestId": 4,
    "title": "Gunga",
    "description": "Gunga fram och tillbaka i en gunga",
    "interestParticipations": null
  },
  {
    "interestId": 5,
    "title": "Cykla",
    "description": "Man trampar på en cykel och känner vinden fånga håret",
    "interestParticipations": null
  },
  {
    "interestId": 6,
    "title": "Rutschkana",
    "description": "Åka rutschkana i lekparken är kul",
    "interestParticipations": null
  },
  {
    "interestId": 7,
    "title": "Bada",
    "description": "Att bada i poolen, havet, sjön, badkaret är roligt",
    "interestParticipations": null
  }
]
```
Lägg till länkar till befintligt InterestParticipationId
![Skärmbild 2024-05-30 232729](https://github.com/jonnaagus/InterestsAPI/assets/144246531/e2240a3c-7e1a-4cce-9cb6-f4ffa7c35c4b)
![Skärmbild 2024-05-30 232950](https://github.com/jonnaagus/InterestsAPI/assets/144246531/84622729-a095-41e7-aa29-f2238b259f4b)
![Skärmbild 2024-05-30 233003](https://github.com/jonnaagus/InterestsAPI/assets/144246531/0927f4f4-8fb8-42ba-b81d-9037aa0662b8)
![Skärmbild 2024-05-30 233015](https://github.com/jonnaagus/InterestsAPI/assets/144246531/bb0e42f3-8cd9-406e-862a-3a286d98fdd8)
Response body:
```json
{
    "personId": 1,
    "personName": "Jonna",
    "contact": "0987654321",
    "interestParticipations": [
      {
        "id": 1,
        "resources": [
          "https://www.svenskfotboll.se/lagsida/hogs-sk--iggesunds-ik/312351/"
        ],
        "fkPersonId": 1,
        "person": null,
        "fkInterestId": 1,
        "interest": null
      },
      {
        "id": 10,
        "resources": null,
        "fkPersonId": 1,
        "person": null,
        "fkInterestId": 3,
        "interest": null
      }
    ]
  },
  {
    "personId": 2,
    "personName": "Wille",
    "contact": "1122354321",
    "interestParticipations": [
      {
        "id": 2,
        "resources": [
          "https://www.hudiksvallsgym.se/"
        ],
        "fkPersonId": 2,
        "person": null,
        "fkInterestId": 3,
        "interest": null
      },
      {
        "id": 9,
        "resources": null,
        "fkPersonId": 2,
        "person": null,
        "fkInterestId": 7,
        "interest": null
      }
    ]
  },
  {
    "personId": 3,
    "personName": "Svante",
    "contact": "1122354111",
    "interestParticipations": [
      {
        "id": 3,
        "resources": [
          "https://www.laget.se/HudiksvallsHC-U10-Team2014/Troop"
        ],
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 2,
        "interest": null
      },
      {
        "id": 11,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 1,
        "interest": null
      },
      {
        "id": 12,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 5,
        "interest": null
      },
      {
        "id": 13,
        "resources": null,
        "fkPersonId": 3,
        "person": null,
        "fkInterestId": 7,
        "interest": null
      }
    ]
  },
```
