using PainTrackerPT.Models.Followups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PainTrackerPT.Common.Followups
{
    interface IFollowupssLog
    {
        FollowupsLog GetLogAt(DateTime dt);
        FollowupsLog GetLogFromTo(DateTime start_dt, DateTime end_dt);
    }

    interface IFollowUp{

    }

    interface IQuestion{

    }

    interface IFollowUpState{
        void askQuestions();
        void answerQuestions();
        void generateAdvice();
        void completeFollowUp();
    }

    interface IPainDiary{

    }
    interface IAnswer{

    }
    interface IAdvice{

    }
    interface IRecommendation{

    }
    interface IFollowUpBuilder{
         FollowUp build();
         FollowUpBuilder setDescription(String description);
         FollowUpBuilder setQuestion(List<IQuestion> questions);
    }
    interface IMediaFatory{
        AbstractClassMedia make(String type);
    }
    interface IAnswerBuilder{
        Answer  build();
        AnswerBuilder setDescription(String description);
        AnswerBuilder setAttachment(List<AbstractClassMedia> attachments);
        AnswerBuilder setAdvice(IAdvice advice);
        AnswerBuilder setFeedback(String feedback);
    }

    interface IQuestionBuilder{
        Question build();
        QuestionBuilder setDescription(String description);
        AnswerBuilder setAnswer(Answer answer); 
    }

    interface IFollowUpController{
        ActionResult Index();
        ActionResult Details(int id);
        ActionResult Create();
        ActionResult Create(IFormCollection collection);
        ActionResult Update();
        ActionResult Edit(int id);
        ActionResult Edit(int id, IFormCollection collection);
        ActionResult Delete(int id);
        ActionResult Delete(int id, IFormCollection collection);
    }

    interface IDoctor{
    }
    interface IFollowUpService{

    }
    interface IQuestionService{
        
    }
    interface IAnswerService{

    }
    interface IRecommendationService{

    }
    interface IAdviceService{

    }
    interface IFollowUpRepository{
        void Create(IFollowUp followUp);
        Task<IEnumerable<FollowUp>> SelectAll();
        Task<FollowUp> SelectById(Guid id);
        void Update(IFollowUp followUp);
        Task<int> Save();
    }
    interface IQuestionRepository{
        void Create(IQuestion question);
        Task<IEnumerable<Question>> SelectAll();
        Task<Question> SelectById(Guid id);
        void Update(IQuestion question);
        Task<int> Save();
    }
    interface IAnswerRepository{
        void Create(IAnswer answer);
        Task<IEnumerable<Answer>> SelectAll();
        Task<Answer> SelectById(Guid id);
        void Update(IAnswer answer);
        Task<int> Save();
    }

    interface IRecommendationRepository{
        void Create(IRecommendation recommendation);
        Task<IEnumerable<Recommendation>> SelectAll();
        Task<Recommendation> SelectById(Guid id);
        void Update(IRecommendation recommendation);
        Task<int> Save();
    }

    interface IAdviceRepository{
        void Create(IAdvice advice);
        Task<IEnumerable<IAdvice>> SelectAll();
        Task<IAdvice> SelectById(Guid id);
        void Update(IAdvice advice);
        Task<int> Save();
    }

    interface IMediaRepository{
        void Create(IAdvice advice);
        Task<IEnumerable<IAdvice>> SelectAll();
        Task<IAdvice> SelectById(Guid id);
        void Update(IAdvice advice);
        Task<int> Save();
    }

    class FollowUpRepository : IFollowUpRepository
    {
        public void Create(IFollowUp followUp)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<FollowUp>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<FollowUp> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IFollowUp followUp)
        {
            throw new NotImplementedException();
        }
    }

    class QuestionRepository : IQuestionRepository
    {
        public void Create(IQuestion question)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Question>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Question> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IQuestion question)
        {
            throw new NotImplementedException();
        }
    }

    class AnswerRepository : IAnswerRepository
    {
        public void Create(IAnswer answer)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Answer>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Answer> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IAnswer answer)
        {
            throw new NotImplementedException();
        }
    }

    class RecommendationRepository : IRecommendationRepository
    {
        public void Create(IRecommendation recommendation)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Recommendation>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<Recommendation> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IRecommendation recommendation)
        {
            throw new NotImplementedException();
        }
    }

    class AdviceRepository : IAdviceRepository
    {
        public void Create(IAdvice advice)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IAdvice>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<IAdvice> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IAdvice advice)
        {
            throw new NotImplementedException();
        }
    }

    class MediaRepository : IMediaRepository
    {
        public void Create(IAdvice advice)
        {
            throw new NotImplementedException();
        }

        public Task<int> Save()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IAdvice>> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Task<IAdvice> SelectById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(IAdvice advice)
        {
            throw new NotImplementedException();
        }
    }

    abstract class AbstractClassMedia{
        public long MediaId {get; set;}
        public String MediaUrl {get; set;}
    }

    class FollowUpController : IFollowUpController
    {
        private IFollowUpService _followUpService;

        public ActionResult Create()
        {
            throw new NotImplementedException();
        }

        public ActionResult Create(IFormCollection collection)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, IFormCollection collection)
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id)
        {
            throw new NotImplementedException();
        }

        public ActionResult Edit(int id, IFormCollection collection)
        {
            throw new NotImplementedException();
        }

        public ActionResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult Update()
        {
            throw new NotImplementedException();
        }
    }

    class PendingQuestionState : IFollowUpState
    {
        public void answerQuestions()
        {
            throw new NotImplementedException();
        }

        public void askQuestions()
        {
            throw new NotImplementedException();
        }

        public void completeFollowUp()
        {
            throw new NotImplementedException();
        }

        public void generateAdvice()
        {
            throw new NotImplementedException();
        }
    }

    class PendingAnswerState : IFollowUpState
    {
        public void answerQuestions()
        {
            throw new NotImplementedException();
        }

        public void askQuestions()
        {
            throw new NotImplementedException();
        }

        public void completeFollowUp()
        {
            throw new NotImplementedException();
        }

        public void generateAdvice()
        {
            throw new NotImplementedException();
        }
    }

    class PendingAdviceState : IFollowUpState
    {
        public void answerQuestions()
        {
            throw new NotImplementedException();
        }

        public void askQuestions()
        {
            throw new NotImplementedException();
        }

        public void completeFollowUp()
        {
            throw new NotImplementedException();
        }

        public void generateAdvice()
        {
            throw new NotImplementedException();
        }
    }

    class CompletedState : IFollowUpState
    {
        public void answerQuestions()
        {
            throw new NotImplementedException();
        }

        public void askQuestions()
        {
            throw new NotImplementedException();
        }

        public void completeFollowUp()
        {
            throw new NotImplementedException();
        }

        public void generateAdvice()
        {
            throw new NotImplementedException();
        }
    }
    class CancelledState : IFollowUpState
    {
        public void answerQuestions()
        {
            throw new NotImplementedException();
        }

        public void askQuestions()
        {
            throw new NotImplementedException();
        }

        public void completeFollowUp()
        {
            throw new NotImplementedException();
        }

        public void generateAdvice()
        {
            throw new NotImplementedException();
        }
    }

    class FollowUp: IFollowUp{
        public Guid FollowUpId {get; set;}
        public IFollowUpState State {get; set;}
        public List<IQuestion> Questions {get; set;}
        public String Description {get; set;}
        public DateTime DateGenerated {get;set;}
    }

    class AnswerBuilder : IAnswerBuilder
    {
        public Answer build()
        {
            throw new NotImplementedException();
        }

        public AnswerBuilder setAdvice(IAdvice advice)
        {
            throw new NotImplementedException();
        }

        public AnswerBuilder setAttachment(List<AbstractClassMedia> attachments)
        {
            throw new NotImplementedException();
        }

        public AnswerBuilder setDescription(string description)
        {
            throw new NotImplementedException();
        }

        public AnswerBuilder setFeedback(string feedback)
        {
            throw new NotImplementedException();
        }
    }

    class MediaFactory : AbstractClassMedia
    {
        public static AbstractClassMedia make(string type)
        {
            throw new NotImplementedException();
        }
    }

    class FollowUpBuilder : IFollowUpBuilder
    {
        public FollowUp build()
        {
            throw new NotImplementedException();
        }

        public FollowUpBuilder setDescription(string description)
        {
            throw new NotImplementedException();
        }

        public FollowUpBuilder setQuestion(List<IQuestion> questions)
        {
            throw new NotImplementedException();
        }
    }

    class Question : IQuestion{
        public Guid QuestionId{get;set;}
        public IAnswer Answer{get;set;}
        public String Description{get;set;}
        public DateTime DateGenerated{get;set;}
    }

    class Answer: IAnswer{
        public Guid AnswerId{get;set;}
        public String Feedback{get;set;}
        public String Description{get;set;}
        public IAdvice Advice{get;set;}
        public List<AbstractClassMedia> AttachmentList{get;set;}
        public DateTime DateGenerated{get;set;}
    }
    class Recommendation : IRecommendation{
        public Guid RecommendationId{get;set;}
        public String Description{get;set;}
        public DateTime DateGenerated{get;set;}
    }

    class QuestionBuilder : IQuestionBuilder
    {
        public IAnswer Answer{get;set;}
        public String Description{get;set;}
        public Question build()
        {
            throw new NotImplementedException();
        }

        public AnswerBuilder setAnswer(Answer answer)
        {
            throw new NotImplementedException();
        }

        public QuestionBuilder setDescription(string description)
        {
            throw new NotImplementedException();
        }
    }


    class Video: AbstractClassMedia{

    }
}
