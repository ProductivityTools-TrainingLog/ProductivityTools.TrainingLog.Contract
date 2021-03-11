<a name='assembly'></a>
# ProductivityTools.TrainingLog.Contract

## Contents

- [Training](#T-ProductivityTools-TrainingLog-Contract-Training 'ProductivityTools.TrainingLog.Contract.Training')
  - [Account](#P-ProductivityTools-TrainingLog-Contract-Training-Account 'ProductivityTools.TrainingLog.Contract.Training.Account')
  - [Application](#P-ProductivityTools-TrainingLog-Contract-Training-Application 'ProductivityTools.TrainingLog.Contract.Training.Application')
  - [AverageSpeed](#P-ProductivityTools-TrainingLog-Contract-Training-AverageSpeed 'ProductivityTools.TrainingLog.Contract.Training.AverageSpeed')
  - [Calories](#P-ProductivityTools-TrainingLog-Contract-Training-Calories 'ProductivityTools.TrainingLog.Contract.Training.Calories')
  - [Comment](#P-ProductivityTools-TrainingLog-Contract-Training-Comment 'ProductivityTools.TrainingLog.Contract.Training.Comment')
  - [Distance](#P-ProductivityTools-TrainingLog-Contract-Training-Distance 'ProductivityTools.TrainingLog.Contract.Training.Distance')
  - [Duration](#P-ProductivityTools-TrainingLog-Contract-Training-Duration 'ProductivityTools.TrainingLog.Contract.Training.Duration')
  - [End](#P-ProductivityTools-TrainingLog-Contract-Training-End 'ProductivityTools.TrainingLog.Contract.Training.End')
  - [ExternalIdList](#P-ProductivityTools-TrainingLog-Contract-Training-ExternalIdList 'ProductivityTools.TrainingLog.Contract.Training.ExternalIdList')
  - [Name](#P-ProductivityTools-TrainingLog-Contract-Training-Name 'ProductivityTools.TrainingLog.Contract.Training.Name')
  - [Source](#P-ProductivityTools-TrainingLog-Contract-Training-Source 'ProductivityTools.TrainingLog.Contract.Training.Source')
  - [Sport](#P-ProductivityTools-TrainingLog-Contract-Training-Sport 'ProductivityTools.TrainingLog.Contract.Training.Sport')
  - [Start](#P-ProductivityTools-TrainingLog-Contract-Training-Start 'ProductivityTools.TrainingLog.Contract.Training.Start')
  - [TrainingId](#P-ProductivityTools-TrainingLog-Contract-Training-TrainingId 'ProductivityTools.TrainingLog.Contract.Training.TrainingId')

<a name='T-ProductivityTools-TrainingLog-Contract-Training'></a>
## Training `type`

##### Namespace

ProductivityTools.TrainingLog.Contract

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Account'></a>
### Account `property`

##### Summary

Id of group of trainings, if you have two accounts, like yours and your partner you could add here id

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Application'></a>
### Application `property`

##### Summary

Application which is the source of data, it could be Endomondo, Sports-Tracker, or anything we want

<a name='P-ProductivityTools-TrainingLog-Contract-Training-AverageSpeed'></a>
### AverageSpeed `property`

##### Summary

Average speed in km/h

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Calories'></a>
### Calories `property`

##### Summary

Calories burned

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Comment'></a>
### Comment `property`

##### Summary

Additional field to describe sport, for example you could add person with who you had been training

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Distance'></a>
### Distance `property`

##### Summary

Distance in meters

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Duration'></a>
### Duration `property`

##### Summary

Training duration in Seconds

<a name='P-ProductivityTools-TrainingLog-Contract-Training-End'></a>
### End `property`

##### Summary

End of the training

<a name='P-ProductivityTools-TrainingLog-Contract-Training-ExternalIdList'></a>
### ExternalIdList `property`

##### Summary

Every training can have multiple external Ids, for example, we registered training in Endomondo, than we improtet it to Training Log and than exported to Sports-Tracker, than in external Id we will have two ids: Endomodno and Sports-Tracker

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Name'></a>
### Name `property`

##### Summary

Free text to describe sport, for example you could add some meaningfull information like Olympics 2020

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Source'></a>
### Source `property`

##### Summary

Every application like Endomondo has source of training and maily it is Manual or GPX

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Sport'></a>
### Sport `property`

##### Summary

Type of sport

<a name='P-ProductivityTools-TrainingLog-Contract-Training-Start'></a>
### Start `property`

##### Summary

Start of the training

<a name='P-ProductivityTools-TrainingLog-Contract-Training-TrainingId'></a>
### TrainingId `property`

##### Summary

Id from the TrainingLog Application
