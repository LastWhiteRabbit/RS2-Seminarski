// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'routine.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Routine _$RoutineFromJson(Map<String, dynamic> json) => Routine()
  ..routineId = json['routineId'] as int?
  ..routineName = json['routineName'] as String?
  ..description = json['description'] as String?
  ..exerciseNames = json['exerciseNames'] as String?;

Map<String, dynamic> _$RoutineToJson(Routine instance) => <String, dynamic>{
      'routineId': instance.routineId,
      'routineName': instance.routineName,
      'description': instance.description,
      'exerciseNames': instance.exerciseNames,
    };
