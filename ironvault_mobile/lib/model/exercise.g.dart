// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'exercise.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Exercise _$ExerciseFromJson(Map<String, dynamic> json) => Exercise()
  ..exerciseId = json['exerciseId'] as int?
  ..exerciseName = json['exerciseName'] as String?
  ..exerciseImage = json['exerciseImage'] as String?;

Map<String, dynamic> _$ExerciseToJson(Exercise instance) => <String, dynamic>{
      'exerciseId': instance.exerciseId,
      'exerciseName': instance.exerciseName,
      'exerciseImage': instance.exerciseImage,
    };
